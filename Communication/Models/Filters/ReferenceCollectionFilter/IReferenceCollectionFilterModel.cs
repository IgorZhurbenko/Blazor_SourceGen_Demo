// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using System;
using System.Linq;
using Common.Extensions.Object;
namespace Communication.Models.Filters.ReferenceCollectionFilter
{
    public interface IReferenceCollectionFilterModel : Communication.Models.IModelBase, IEquatable<IReferenceCollectionFilterModel>
    {
        public System.Boolean Exclusive { get; }
        public System.UInt32 Limit { get; }
        public Communication.Models.Filters.ReferenceFilter.IReferenceFilterModel Any { get; set; }
        public Communication.Models.Filters.ReferenceFilter.IReferenceFilterModel All { get; set; }
        bool IEquatable<IReferenceCollectionFilterModel>.Equals(IReferenceCollectionFilterModel other)
        {
            var result = Exclusive.CompareConsideringNulls(other.Exclusive) && Limit.CompareConsideringNulls(other.Limit) && Any.CompareConsideringNulls(other.Any) && All.CompareConsideringNulls(other.All);
            return result;
        }
    }
}