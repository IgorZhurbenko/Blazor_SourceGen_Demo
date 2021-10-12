// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using System;
using System.Linq;
using Common.Extensions.Object;
namespace Communication.Models.Filters.CollectionFilter
{
    public interface ICollectionFilterModel : Communication.Models.IModelBase, IEquatable<ICollectionFilterModel>
    {
        public System.Boolean Exclusive { get; }
        public System.UInt32 Limit { get; }
        public Communication.Models.Filters.NumberFilter.INumberFilterModel Count { get; set; }
        bool IEquatable<ICollectionFilterModel>.Equals(ICollectionFilterModel other)
        {
            var result = Exclusive.CompareConsideringNulls(other.Exclusive) && Limit.CompareConsideringNulls(other.Limit) && Count.CompareConsideringNulls(other.Count);
            return result;
        }
    }
}