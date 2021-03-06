// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using System;
using System.Linq;
using Common.Extensions.Object;
namespace Communication.Models.Filters.StringFilter
{
    public interface IStringFilterModel : Communication.Models.IModelBase, IEquatable<IStringFilterModel>
    {
        public System.String Pattern { get; }
        public System.Boolean Exclusive { get; }
        public System.UInt32 Limit { get; }
        bool IEquatable<IStringFilterModel>.Equals(IStringFilterModel other)
        {
            var result = Pattern.CompareConsideringNulls(other.Pattern) && Exclusive.CompareConsideringNulls(other.Exclusive) && Limit.CompareConsideringNulls(other.Limit);
            return result;
        }
    }
}