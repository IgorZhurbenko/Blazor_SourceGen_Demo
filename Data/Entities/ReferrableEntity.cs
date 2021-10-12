using SourceGeneration.Attributes.Data;
using SourceGeneration.Permissions;
using System;
using System.Linq.Expressions;

namespace Data.Entities
{
    [Permissions("Add", "Edit", "Delete", "Read", "See")]
    [SourceGeneration.Attributes.Data.Entity.Referrable]
    public abstract partial class ReferrableEntity : Entity
    {
        //public static Expression<Func<Entity, string>> ReferenceRepresentationSelector { get; } = e => ReferrableEntity.
        [ExcludeFromModels]
        public DateTime DateCreated { get; set; }

        [ExcludeFromModels]
        public DateTime DateUpdated { get; set; }

        [ExcludeFromModels]
        public string Representation { get; set; }

        public virtual string GetRepresentation()
        {
            return $"{Metadata.Representation.Singular} of {DateCreated.ToShortDateString()}";
        }

        public override void BeforeSave()
        {
            if (DateCreated == default(DateTime))
            {
                DateCreated = DateTime.UtcNow;
                DateUpdated = DateCreated;
            }
            else
            {
                DateUpdated = DateTime.UtcNow;
            }
            Representation = GetRepresentation();
        }
    } 
}