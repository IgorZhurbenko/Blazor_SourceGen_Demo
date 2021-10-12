using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace SourceGeneration.Common
{
    public class CommonSymbols
    {
        public static readonly string CollectionNamespace = typeof(List<object>).Namespace;
        public INamedTypeSymbol String;
        public INamedTypeSymbol ID;

    }
}
