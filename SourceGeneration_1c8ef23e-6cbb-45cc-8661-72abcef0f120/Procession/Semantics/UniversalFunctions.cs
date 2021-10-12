using Microsoft.CodeAnalysis;
using SourceGeneration.Attributes.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SourceGeneration.Attributes.Data;
using SourceGeneration.Transport;
using SourceGeneration.Permissions;

namespace SourceGeneration.Procession.Semantics
{
    public static class UniversalFunctions
    {
        private static readonly string _referrableAttributeFullSignature = typeof(ReferrableAttribute).FullName;
        private static readonly string _entityAttributeFullSignature = typeof(EntityAttribute).FullName;

        private const string _iCollectionSignature = "System.Collections.Generic.ICollection";
        private static IReadOnlyDictionary<string, string> WordExceptions = new Dictionary<string, string>() {
                { "man", "men" },
                { "woman", "women" },
                { "child", "children" },
                { "tooth", "teeth" },
                { "foot", "feet" },
                { "mouse", "mice" },
                { "belief", "beliefs" } };

        public static string ToPlural(this string str)
        {
            if (WordExceptions.ContainsKey(str.ToLowerInvariant()))
            {
                return WordExceptions[str.ToLowerInvariant()];
            }
            else if (str.EndsWith("y", StringComparison.OrdinalIgnoreCase) &&
                !str.EndsWith("ay", StringComparison.OrdinalIgnoreCase) &&
                !str.EndsWith("ey", StringComparison.OrdinalIgnoreCase) &&
                !str.EndsWith("iy", StringComparison.OrdinalIgnoreCase) &&
                !str.EndsWith("oy", StringComparison.OrdinalIgnoreCase) &&
                !str.EndsWith("uy", StringComparison.OrdinalIgnoreCase))
            {
                return str.Substring(0, str.Length - 1) + "ies";
            }
            else if (str.EndsWith("us", StringComparison.InvariantCultureIgnoreCase))
            {

                return str + "es";
            }
            else if (str.EndsWith("ss", StringComparison.InvariantCultureIgnoreCase))
            {
                return str + "es";
            }
            else if (str.EndsWith("s", StringComparison.InvariantCultureIgnoreCase))
            {
                return str;
            }
            else if (str.EndsWith("x", StringComparison.InvariantCultureIgnoreCase) ||
                str.EndsWith("ch", StringComparison.InvariantCultureIgnoreCase) ||
                str.EndsWith("sh", StringComparison.InvariantCultureIgnoreCase))
            {
                return str + "es";
            }
            else if (str.EndsWith("f", StringComparison.InvariantCultureIgnoreCase) && str.Length > 1)
            {
                return str.Substring(0, str.Length - 1) + "ves";
            }
            else if (str.EndsWith("fe", StringComparison.InvariantCultureIgnoreCase) && str.Length > 2)
            {
                return str.Substring(0, str.Length - 2) + "ves";
            }
            else
            {
                return str + "s";
            }
        }

        public static string GetFullNamespace(this INamedTypeSymbol symbol)
        {
            return symbol.ContainingNamespace.ToDisplayString();
            string res = "";
            var curNamespace = symbol.ContainingNamespace;
            while (curNamespace != null && !string.IsNullOrWhiteSpace(curNamespace.Name))
            {
                res = curNamespace.Name + "." + res;
                curNamespace = curNamespace.ContainingNamespace;
            }
            return res;
        }

        public static string GetFullSignature(this INamedTypeSymbol symbol)
        {
            string fullNamespace = symbol.ContainingNamespace?.ToDisplayString();

            if (symbol.IsGenericType)
            {
                return $"{fullNamespace}.{symbol.ConstructedFrom.Name}<{(symbol.TypeArguments.First() as INamedTypeSymbol)?.GetFullSignature() ?? throw new Exception($"Could not get full signature for {symbol.Name}.")}>";
            }
            else
            {
                return $"{fullNamespace}.{symbol.Name}";
            }
        }

        public static IEnumerable<INamedTypeSymbol> AllBaseClassesHierarchy(this INamedTypeSymbol symbol)
        {
            var res = new List<INamedTypeSymbol>();
            var cur = symbol.BaseType;
            while (cur != null)
            {
                res.Add(cur);
                cur = cur.BaseType;
            }
            return res;
        }

        public static List<INamedTypeSymbol> AllBaseClassesHierarchyIncludingSelf(this INamedTypeSymbol symbol)
        {
            var res = new List<INamedTypeSymbol>();
            var cur = symbol;
            while (cur != null)
            {
                res.Add(cur);
                cur = cur.BaseType;
            }
            return res;
        }


        public static bool IsHeirOf(this INamedTypeSymbol heir, INamedTypeSymbol parent)
        {
            var res = AllBaseClassesHierarchy(heir).Any(bc => SymbolEqualityComparer.Default.Equals(bc, parent));
            return res;
        }

        public static bool HasParent(this INamedTypeSymbol heir, string parentSignature)
        {
            var res = AllBaseClassesHierarchy(heir).Any(bc => GetFullSignature(bc) == parentSignature);
            return res;
        }

        public static bool IsCapital(this char c)
        {
            return c.ToString().ToUpper() == c.ToString();
        }

        public static string PascalToHuman(this string str)
        {
            List<string> capitalWords = new List<string>();
            char prevSymbol = ' ';
            foreach (var symbol in str)
            {
                if (IsCapital(symbol) && !IsCapital(prevSymbol))
                {
                    capitalWords.Add(symbol.ToString());
                }
                else if (capitalWords.Any())
                {
                    capitalWords[capitalWords.Count - 1] = capitalWords[capitalWords.Count - 1] + symbol;
                }
                else
                {
                    capitalWords.Add(symbol.ToString().ToUpper());
                }
                prevSymbol = symbol;
            }
            return string.Join(" ", capitalWords);
        }

        public static bool IsPrimitiveOrNullablePrimitive(this INamedTypeSymbol type)
        {
            if (type.IsGenericType)
            {
                if (type.TypeArguments.Length == 1 && type.ToDisplayString().StartsWith("System.Nullable<"))
                {
                    var typeArg = type.TypeArguments.First();
                    return typeArg.IsValueType || typeArg.ToDisplayString() == "System.String";
                }
                else { return false; }
            }
            return type.IsValueType || type.GetFullSignature() == "System.String";
        }

        public static string Join(this IEnumerable<string> strings, string joiner = ", ")
        {
            return string.Join(joiner, strings);
        }

        public static INamedTypeSymbol IsCollectionOf(this ITypeSymbol type)
        {
            string typeSignature = type.ToDisplayString();

            var nts = type as INamedTypeSymbol;
            if (nts == null)
            {
                return null;
            }
            bool isCollection = typeSignature.StartsWith($"{_iCollectionSignature}<");

            if (!isCollection) { return null; }

            return nts.TypeArguments.First() as INamedTypeSymbol;
        }

        public static IEnumerable<INamedTypeSymbol> GetReallyAllInterfaces(this INamedTypeSymbol type)
        {
            var result = type.AllInterfaces.Union(type.AllInterfaces.SelectMany(i => i.GetReallyAllInterfaces())).Distinct();

            return result;
        }


        public static bool ImplementsInterface<TInterface>(this INamedTypeSymbol type)
        {
            string typeSignature = type.ToDisplayString();

            string intSignature = typeof(TInterface).FullName;


            var interfaces = type.GetReallyAllInterfaces().Union(new[] { type });

            return interfaces.Any(i => i.ToDisplayString() == intSignature);
        }

        public static bool IsReferrable(this INamedTypeSymbol potentialReferrable)
        {
            return potentialReferrable.TiedToAttribute<ReferrableAttribute>();
        }

        public static bool IsEntity(this INamedTypeSymbol potentialReferrable)
        {
            return potentialReferrable.TiedToAttribute<EntityAttribute>();
        }

        public static bool IsFilter(this INamedTypeSymbol potentialFilter)
        {
            return potentialFilter.TiedToAttribute<FilterAttribute>();
        }

        public static bool TiedToAttribute<TAttribute>(this INamedTypeSymbol symbol) where TAttribute : System.Attribute
        {
            if (symbol == null)
            {
                return false;
            }
            string attributeSignature = typeof(TAttribute).FullName;

            var allBases = symbol.AllBaseClassesHierarchyIncludingSelf();

            bool result = allBases.Any(c => c.GetAttributes().Any(a => a.AttributeClass.AllBaseClassesHierarchyIncludingSelf().Any(ac => ac.ToDisplayString() == attributeSignature)));

            return result;
        }


        public static TypePrescription PickTypePrescription(this IEnumerable<TypePrescription> typePrescriptions, INamedTypeSymbol namedTypeSymbol)
        {
            if (namedTypeSymbol == null) { return null; }
            var prescribedType = namedTypeSymbol.AllInterfaces.Union(new[] { namedTypeSymbol }).Select(i => typePrescriptions.FirstOrDefault(t => t.PureDotnetType == i.ToDisplayString())).FirstOrDefault(r => r != null);
            return prescribedType;
        }

        public static bool HasAttribute<TAttr>(this ISymbol symbol)
            where TAttr : Attribute
        {
            return symbol.GetAttributes().Any(a => a.AttributeClass.ToDisplayString() == typeof(TAttr).FullName);
        }

        public static IEnumerable<string> GetAttributeConstructorParametersAsStringsFromArray<TAttr>(this ISymbol symbol)
        {
            string attrSignature = typeof(TAttr).FullName;
            var attrData = symbol.GetAttributes().FirstOrDefault(a => a.AttributeClass.ToDisplayString() == attrSignature);
            if (attrData == null)
            {
                return new string[0];
            }
            return attrData.ConstructorArguments.SelectMany(ca => ca.Values.Select(v=>v.Value.ToString()));
        }

        public static IEnumerable<string> GetAllPermissionsFromUpperClasses(this INamedTypeSymbol symbol)
        {
            return symbol.AllBaseClassesHierarchyIncludingSelf().SelectMany(c => c.GetAttributeConstructorParametersAsStringsFromArray<PermissionsAttribute>());
        }
    }
}
