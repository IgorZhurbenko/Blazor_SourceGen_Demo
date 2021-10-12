﻿using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SourceGeneration.Procession.Semantics
{
    public static class ActionsFunctions
    {
        const string permissionsAttribute = "SourceGeneration.Permissions.PermissionsAttribute";
        public static IEnumerable<String> FindActions(this INamedTypeSymbol symbol)
        {
            var result = new List<string>();
            if (symbol == null)
            {
                return result;
            }
            var pa = symbol.GetAttributes().FirstOrDefault(a => a.AttributeClass.GetFullSignature() == permissionsAttribute);
            if (pa != null)
            {
                var permissions = pa.ConstructorArguments.SelectMany(ca => ca.Values);
                result.AddRange(permissions.Select(p => p.Value.ToString()));
            }
            if (symbol.BaseType != null)
            {
                var parentPermissions = FindActions(symbol.BaseType);
                result.AddRange(parentPermissions);
            }
            return result.Distinct();
        }

        public static string ComposePermissionsNamespace(string symbolNamespace, string projectName)
        {
            string endingNamespace = string.Join(".", symbolNamespace.Split('.').Skip(1));
            string baseNamespace = $"{projectName}.Autogenerated.Permissions";
            return $"{baseNamespace}.{endingNamespace}";
        }

        public static string ComposePathFromClassFullName(string symbolNamespace)
        {
            return symbolNamespace.Replace(".", @"/") + ".cs";
        }
    }
}
