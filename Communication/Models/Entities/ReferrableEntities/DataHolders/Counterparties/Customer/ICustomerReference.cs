// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using System;
namespace Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer
{
    public interface ICustomerReference : Communication.Models.IReference<Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerModel>, IEquatable<ICustomerReference>
    {
        bool IEquatable<ICustomerReference>.Equals(ICustomerReference other)
        {
            return ID == other.ID;
        }
    }
}