// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using System;
namespace Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder
{
    public interface IOutcomingOrderReference : Communication.Models.IReference<Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderModel>, IEquatable<IOutcomingOrderReference>
    {
        bool IEquatable<IOutcomingOrderReference>.Equals(IOutcomingOrderReference other)
        {
            return ID == other.ID;
        }
    }
}