// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

namespace Communication.Models.Filters.ReferenceFilter
{
    public partial class ReferenceFilterModel : Communication.Models.ModelBase, Communication.Models.Filters.ReferenceFilter.IReferenceFilterModel
    {
        public System.Collections.Generic.IList<System.UInt32> In { get; set; }
        public System.Collections.Generic.IList<System.UInt32> NotIn { get; set; }
        public System.Boolean Exclusive { get; set; }
        public System.UInt32 Limit { get; set; }
        public Communication.Models.Filters.StringFilter.IStringFilterModel Representation { get; set; }
    }
}