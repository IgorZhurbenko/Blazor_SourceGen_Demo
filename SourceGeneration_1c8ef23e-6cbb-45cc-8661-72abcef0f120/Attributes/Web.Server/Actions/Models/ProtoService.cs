using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace SourceGeneration.Attributes.Web.Server.Actions.Models
{
    public class ProtoService
    {
        public string Name;
        public IEnumerable<ProtoMethod> Methods;
        public INamedTypeSymbol From;
    }
}
