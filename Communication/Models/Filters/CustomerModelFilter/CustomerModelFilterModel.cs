// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

namespace Communication.Models.Filters.CustomerModelFilter
{
    public partial class CustomerModelFilterModel : Communication.Models.ModelBase, Communication.Models.Filters.CustomerModelFilter.ICustomerModelFilterModel
    {
        public System.Boolean Exclusive { get; set; }
        public System.UInt32 Limit { get; set; }
        public Communication.Models.Filters.StringFilter.IStringFilterModel Name { get; set; }
        public Communication.Models.Filters.ReferenceFilter.IReferenceFilterModel Reference { get; set; }
    }
}