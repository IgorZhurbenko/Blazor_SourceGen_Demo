using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SourceGeneration.Attributes.Data.Entity.Models
{

    public class Representation
    {
        public string Plural;
        public string Original;
        public string Singular;
    }

    public class CreatedModelInterface : Derived<Entity>, IClassInterface
    {
        public ReferenceInterface Reference;
        public CreatedEntityModel DefaultModel;
        public bool IsReferrable;
        public bool IsEntity;
        public bool IsFilter;
        public CreatedModelInterface FilterFor;
        public Dictionary<string, Component> Components;
    }
    public class CreatedModelInterfaces
    {
        public CreatedModelInterface ModelInterfaceBase;
        public IEnumerable<CreatedModelInterface> Items;
    }
}
