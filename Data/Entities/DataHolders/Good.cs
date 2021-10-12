using System;
using System.Linq.Expressions;

namespace Data.Entities.DataHolders
{
    public partial class Good : DataHolder
    {
        public static Expression<Func<Good, string>> ReferenceRepresentation { get; } = p => p.Name;
        public System.Collections.Generic.ICollection<Employee> ResponsibleEmployees { get; set; }
        public string Name { get; set; }

        public override string GetReferenceRepresentation()
        {
            return Name;
        }

        public override string GetRepresentation()
        {
            return Name;
        }
    }
}