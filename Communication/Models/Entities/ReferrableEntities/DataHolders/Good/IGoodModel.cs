// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using System;
using System.Linq;
using Common.Extensions.Object;
namespace Communication.Models.Entities.ReferrableEntities.DataHolders.Good
{
    public interface IGoodModel : Communication.Models.IModelBase, IEquatable<IGoodModel>
    {
        public System.String Name { get; set; }
        public Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference Reference { get; }
        public System.Collections.Generic.IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeReference> ResponsibleEmployees { get; }
        bool IEquatable<IGoodModel>.Equals(IGoodModel other)
        {
            var result = Name.CompareConsideringNulls(other.Name) && Reference.CompareConsideringNulls(other.Reference) && ResponsibleEmployees.Count == other.ResponsibleEmployees.Count && ResponsibleEmployees.All(p1 => other.ResponsibleEmployees.Any(p2 => p1.CompareConsideringNulls(p2)));
            return result;
        }
    }
}