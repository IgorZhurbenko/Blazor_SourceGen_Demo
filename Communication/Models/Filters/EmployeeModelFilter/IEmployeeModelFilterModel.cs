// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using System;
using System.Linq;
using Common.Extensions.Object;
namespace Communication.Models.Filters.EmployeeModelFilter
{
    public interface IEmployeeModelFilterModel : Communication.Models.IModelBase, IEquatable<IEmployeeModelFilterModel>
    {
        public System.Boolean Exclusive { get; }
        public System.UInt32 Limit { get; }
        public Communication.Models.Filters.StringFilter.IStringFilterModel FirstName { get; set; }
        public Communication.Models.Filters.StringFilter.IStringFilterModel LastName { get; set; }
        public Communication.Models.Filters.ReferenceFilter.IReferenceFilterModel Reference { get; set; }
        public Communication.Models.Filters.ReferenceFilter.IReferenceFilterModel Mentor { get; set; }
        public Communication.Models.Filters.ReferenceCollectionFilter.IReferenceCollectionFilterModel ResponsibleForGoods { get; set; }
        bool IEquatable<IEmployeeModelFilterModel>.Equals(IEmployeeModelFilterModel other)
        {
            var result = Exclusive.CompareConsideringNulls(other.Exclusive) && Limit.CompareConsideringNulls(other.Limit) && FirstName.CompareConsideringNulls(other.FirstName) && LastName.CompareConsideringNulls(other.LastName) && Reference.CompareConsideringNulls(other.Reference) && Mentor.CompareConsideringNulls(other.Mentor) && ResponsibleForGoods.CompareConsideringNulls(other.ResponsibleForGoods);
            return result;
        }
    }
}