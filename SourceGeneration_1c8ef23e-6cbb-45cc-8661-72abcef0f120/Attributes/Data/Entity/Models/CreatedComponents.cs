using SourceGeneration.Procession.Semantics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SourceGeneration.Attributes.Data.Entity.Models
{
    public class ModelComponents
    {
        public CreatedModelInterface Model;
        public Dictionary<string, Component> Components;
    }

    public class Component : Derived<CreatedModelInterface>
    {
        public override string FullSignature
        {
            get
            {
                string directoryStructure = this.FileWithDefinitionLocation.Split('/').TakeWhile(f => !f.EndsWith(".razor")).Join(".");
                string result = directoryStructure + $".{Name}";
                return result;
            }
        }
    }

    public class CreatedComponents
    {
        public IEnumerable<ModelComponents> Items;
    }
}
