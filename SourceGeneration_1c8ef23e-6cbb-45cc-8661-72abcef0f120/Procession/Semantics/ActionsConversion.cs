using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SourceGeneration.Auxiliary;

namespace SourceGeneration.Procession.Semantics
{
    public static class ActionsConversion
    {
        public static  string ToProtoDotnetEquivalent(this INamedTypeSymbol type)
        {
            if (type.IsGenericType)
            {
                string fullSignature = type.GetFullSignature();
                if (!fullSignature.StartsWith("System.Collections.Generic.ICollection<") || type.TypeArguments.Length != 1)
                {
                    return null;
                }

                var itemType = type.TypeArguments.First() as INamedTypeSymbol;

                if (itemType == null) { return null; }

                string protoType = GetProtoName(itemType);

                return $"Communication.ProtoModels.{protoType}Collection";
            }

            return GetProtoName(type);
        }

        private static string GetProtoName(INamedTypeSymbol itemType)
        {
            string ending = itemType.GetFullSignature().Split('.').Last();

            string protoType = itemType.TypeKind == TypeKind.Interface &&
                ending.StartsWith("I") ? string.Concat(ending.Skip(1)) : ending;
            return protoType;
        }
    }
}
