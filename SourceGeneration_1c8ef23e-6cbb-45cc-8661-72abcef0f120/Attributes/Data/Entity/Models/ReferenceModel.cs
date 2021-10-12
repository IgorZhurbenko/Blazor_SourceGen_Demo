using System;
using System.Collections.Generic;
using System.Text;

namespace SourceGeneration.Attributes.Data.Entity.Models
{
    public class ReferenceModel : Derived<CreatedEntityModel>
    {
        public ReferenceInterface FromInterface;
    }

    public class CreatedReferenceModels
    {
        public IEnumerable<ReferenceModel> Items;
        public ReferenceModel BaseModel;
    }
}
