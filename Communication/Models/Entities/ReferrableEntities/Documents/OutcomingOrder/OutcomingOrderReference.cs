// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

namespace Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder
{
    public class OutcomingOrderReference : Communication.Models.Reference<Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderModel>, Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference
    {
        public override bool Equals(object other)
        {
            return other is IOutcomingOrderReference rightType && rightType.ID == ID;
        }
    }
}