// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

namespace Communication.Models.PaginationRequests.IncomingOrderLinePaginationRequest
{
    public partial class IncomingOrderLinePaginationRequestModel : Communication.Models.ModelBase, Communication.Models.PaginationRequests.IncomingOrderLinePaginationRequest.IIncomingOrderLinePaginationRequestModel
    {
        public System.UInt32 PageNumber { get; set; }
        public Communication.Models.Filters.IncomingOrderLineModelFilter.IIncomingOrderLineModelFilterModel Filter { get; set; } = new Communication.Models.Filters.IncomingOrderLineModelFilter.IncomingOrderLineModelFilterModel();
    }
}