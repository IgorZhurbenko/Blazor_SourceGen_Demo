// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

namespace Communication.Models.Entities.ReferrableEntities.Documents.IncomingOrder
{
    public class IncomingOrderReference : Communication.Models.Reference<Communication.Models.Entities.ReferrableEntities.Documents.IncomingOrder.IIncomingOrderModel>, Communication.Models.Entities.ReferrableEntities.Documents.IncomingOrder.IIncomingOrderReference
    {
        public override bool Equals(object other)
        {
            return other is IIncomingOrderReference rightType && rightType.ID == ID;
        }
    }
}