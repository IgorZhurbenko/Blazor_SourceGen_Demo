using DualDependencies.Interfaces;
using Microsoft.CodeAnalysis;
using SourceGeneration.Procession.Semantics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DualDependencies { }
namespace DualDependencies.Interfaces { }

namespace SourceGeneration.Attributes.Data.Entity.Models
{
    public class Transportables
    {
        public IEnumerable<Entity> Items { get; set; }
        public INamedTypeSymbol EntityBaseClass { get; set; }

    }

    public enum MemberType
    {
        Property, Field, Method
    }

    public class Entity : Derived
    {
        public string ComponentsFolder { get; set; }
        public INamedTypeSymbol Symbol { get; set; }

    }
}
