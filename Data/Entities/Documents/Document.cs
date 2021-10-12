using SourceGeneration.Permissions;
using System;
using System.Linq.Expressions;

namespace Data.Entities.Documents
{
    [Permissions("Move")]
    public abstract partial class Document : ReferrableEntity
    {
        public static Expression<Func<Document, string>> ReferenceRepresentation { get; } = d => d.Number;

        public string Number { get; set; }

        public override string GetReferenceRepresentation() => $"{Metadata.Representation.Singular} #{Number}";
    }
}