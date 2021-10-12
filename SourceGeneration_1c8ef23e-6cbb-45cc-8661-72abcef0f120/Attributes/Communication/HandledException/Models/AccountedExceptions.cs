using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace SourceGeneration.Attributes.Data.HandledException.Models
{
    public class AccountedExceptions
    {
        public List<AccountedException> Items;
    }

    public class AccountedException
    {
        public int Index;
        public string Name;
        public string Namespace;
        
        [Newtonsoft.Json.JsonIgnore]
        public string FullSignature => $"{Namespace}.{Name}";
        [Newtonsoft.Json.JsonIgnore]
        public INamedTypeSymbol Symbol;
    }
}
