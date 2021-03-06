// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using System;
using System.Linq;
using Common.Extensions.Object;
namespace Communication.Models.Filters.ReferenceFilter
{
    public interface IReferenceFilterModel : Communication.Models.IModelBase, IEquatable<IReferenceFilterModel>
    {
        public System.Collections.Generic.IList<System.UInt32> In { get; }
        public System.Collections.Generic.IList<System.UInt32> NotIn { get; }
        public System.Boolean Exclusive { get; }
        public System.UInt32 Limit { get; }
        public Communication.Models.Filters.StringFilter.IStringFilterModel Representation { get; set; }
        bool IEquatable<IReferenceFilterModel>.Equals(IReferenceFilterModel other)
        {
            var result = Exclusive.CompareConsideringNulls(other.Exclusive) && Limit.CompareConsideringNulls(other.Limit) && Representation.CompareConsideringNulls(other.Representation) && In.Count == other.In.Count && NotIn.Count == other.NotIn.Count && In.All(p1 => other.In.Any(p2 => p1.CompareConsideringNulls(p2))) && NotIn.All(p1 => other.NotIn.Any(p2 => p1.CompareConsideringNulls(p2)));
            return result;
        }
    }
}