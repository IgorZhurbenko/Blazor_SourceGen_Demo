// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using SourceGeneration.Attributes.Data.Entity;
namespace Data.CommunicationContracts
{
    public class OutcomingOrderModelFilter : Filter, IFilterFor<Data.Entities.Documents.OutcomingOrder>
    {
        public StringFilter Number { get; }
        public ReferenceFilter Reference { get; }
        public ReferenceCollectionFilter OrdersIncoming { get; }
    }
}