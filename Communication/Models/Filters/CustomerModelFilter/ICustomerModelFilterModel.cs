// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using System;
using System.Linq;
using Common.Extensions.Object;
namespace Communication.Models.Filters.CustomerModelFilter
{
    public interface ICustomerModelFilterModel : Communication.Models.IModelBase, IEquatable<ICustomerModelFilterModel>
    {
        public System.Boolean Exclusive { get; }
        public System.UInt32 Limit { get; }
        public Communication.Models.Filters.StringFilter.IStringFilterModel Name { get; set; }
        public Communication.Models.Filters.ReferenceFilter.IReferenceFilterModel Reference { get; set; }
        bool IEquatable<ICustomerModelFilterModel>.Equals(ICustomerModelFilterModel other)
        {
            var result = Exclusive.CompareConsideringNulls(other.Exclusive) && Limit.CompareConsideringNulls(other.Limit) && Name.CompareConsideringNulls(other.Name) && Reference.CompareConsideringNulls(other.Reference);
            return result;
        }
    }
}