// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using System;
using System.Linq;
using Common.Extensions.Object;
namespace Communication.Models.PaginationRequests.IncomingOrderPaginationRequest
{
    public interface IIncomingOrderPaginationRequestModel : Communication.Models.IModelBase, IEquatable<IIncomingOrderPaginationRequestModel>
    {
        public System.UInt32 PageNumber { get; }
        public Communication.Models.Filters.IncomingOrderModelFilter.IIncomingOrderModelFilterModel Filter { get; set; }
        bool IEquatable<IIncomingOrderPaginationRequestModel>.Equals(IIncomingOrderPaginationRequestModel other)
        {
            var result = PageNumber.CompareConsideringNulls(other.PageNumber) && Filter.CompareConsideringNulls(other.Filter);
            return result;
        }
    }
}