using Microsoft.CodeAnalysis;
using SourceGeneration.Procession.Semantics;
using System;

namespace SourceGeneration.Attributes.Data.Entity.Models
{
    public class Member
    {
        public bool Gettable;
        public bool Settable;
        public MemberType Type;
        public string Name;
        public ISymbol Symbol;
        public Member Init()
        {
            if (Symbol != null)
            {
                Type = Symbol.Kind == SymbolKind.Method ? MemberType.Method : Symbol.Kind == SymbolKind.Property ? MemberType.Property : MemberType.Field;
                Name = Symbol.Name;

                if (Symbol is IFieldSymbol field)
                {
                    ValueTypePresent = field.Type as INamedTypeSymbol;
                    Gettable = true;
                    Settable = !field.IsReadOnly;
                }
                else if (Symbol is IPropertySymbol prop)
                {
                    ValueTypePresent = prop.Type as INamedTypeSymbol;
                    Gettable = prop.GetMethod != null;
                    Settable = prop.SetMethod != null;
                } else if (Symbol is IMethodSymbol method)
                {
                    ValueTypePresent = method.ReturnType as INamedTypeSymbol;
                    Settable = false;
                    Gettable = false;
                }
                
                IsCollectionOfPresent = ValueTypePresent?.IsCollectionOf();
            }
            return this;
        }

        public Member()
        {

        }

        public Member(IFieldSymbol symbol)
        {
            Symbol = symbol;
            Init();
        }
        public Member(IPropertySymbol symbol)
        {
            Symbol = symbol;
            Init();
        }
        public Member(IMethodSymbol symbol)
        {
            Symbol = symbol;
            Init();
        }
        public INamedTypeSymbol ValueTypePresent;
        public Derived ValueTypeCreated;
        public bool RefersToOtherModel => ValueTypeCreated != null || IsCollectionOfCreated != null;
        public bool IsGenericCollectionType => IsCollectionOfPresent != null || IsCollectionOfCreated != null;
        public INamedTypeSymbol IsCollectionOfPresent;
        public Derived IsCollectionOfCreated;

        /// <summary>
        /// Only for fields and properties. Includes closing semicolon.
        /// </summary>
        public string DeclarationString
        {
            get
            {
                if (Type != MemberType.Method)
                {
                    string typeString;
                    if (IsGenericCollectionType)
                    {
                        string iCollectionFullSignature = Common.CommonSymbols.CollectionNamespace + ".IList";
                        typeString = IsCollectionOfPresent?.GetFullSignature() ?? IsCollectionOfCreated.FullSignature;
                        typeString = $"{iCollectionFullSignature}<{typeString}>";
                    }
                    else if (ValueTypePresent != null)
                    {
                        typeString = ValueTypePresent.GetFullSignature();
                    }
                    else if (ValueTypeCreated != null)
                    {
                        typeString = ValueTypeCreated.FullSignature;
                    }
                    else { throw new Exception("Must have value type to derive declaration string."); }

                    string gettersSetter = Type == MemberType.Property ? $"{{ { (Gettable ? "get;" : "")} { (Settable ? "set;" : "")} }}" : ";";
                    return $"{typeString} {Name} {gettersSetter}";
                }
                else { throw new NotImplementedException(); }
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Member member && member.Name == this.Name;
        }

    }
}
