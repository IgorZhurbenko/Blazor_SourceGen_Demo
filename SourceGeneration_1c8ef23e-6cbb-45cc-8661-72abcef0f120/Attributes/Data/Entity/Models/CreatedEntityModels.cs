using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SourceGeneration.Attributes.Data.Entity.Models
{
    public class CreatedEntityModel : Derived<Entity>
    {
        public ReferenceInterface Reference;
        public CreatedModelInterface FromInterface;
        
    }
    public class CreatedEntityModels
    {
        public CreatedEntityModel ModelBase;
        public IEnumerable<CreatedEntityModel> Items;
    }
}
