// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using SourceGeneration.Attributes.Data.Entity;
namespace Data.CommunicationContracts
{
    public class GoodModelFilter : Filter, IFilterFor<Data.Entities.DataHolders.Good>
    {
        public StringFilter Name { get; }
        public ReferenceFilter Reference { get; }
        public ReferenceCollectionFilter ResponsibleEmployees { get; }
    }
}