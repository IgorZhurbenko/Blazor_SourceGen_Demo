// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using System.Linq;
using Communication.Common;
using Google.Protobuf.Collections;
using System.Collections.Generic;
using Communication.ProtoModels.Conversion;
using System.Collections;
using Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer;
namespace Communication.ProtoModels
{
    public sealed partial class CustomerReference : Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerReference
    {
        public static implicit operator CustomerReferenceMessage(CustomerReference message)
        {
            return new()
            {Message = message};
        }
        public static implicit operator CustomerReference(CustomerReferenceMessage message)
        {
            return message.Message;
        }
    }
    public sealed partial class CustomerReferenceList : IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerReference>
    {
        internal ListWrapper<CustomerReference, RepeatedField<CustomerReference>, ICustomerReference> Wrapper { get; private set; }
        public CustomerReferenceList(RepeatedField<CustomerReference> itemsParameter)
        {
            message_ = itemsParameter;
            OnConstruction();
        }
        partial void OnConstruction()
        {
            Wrapper = new ListWrapper<CustomerReference, RepeatedField<CustomerReference>, ICustomerReference>(Message, i => i.ToProto());
        }
        Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerReference IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerReference>.this[int index] { get => Wrapper[index]; set => Wrapper[index] = value; }
        int IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerReference>.IndexOf(Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerReference item) => Wrapper.IndexOf(item);
        void IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerReference>.Insert(int index, Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerReference item) => Wrapper.Insert(index, item);
        void IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerReference>.RemoveAt(int index) => Wrapper.RemoveAt(index);
        int ICollection<Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerReference>.Count => Wrapper.Count;
        bool ICollection<Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerReference>.IsReadOnly => Wrapper.IsReadOnly;
        void ICollection<Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerReference>.Add(Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerReference item) => Wrapper.Add(item);
        void ICollection<Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerReference>.Clear() => Wrapper.Clear();
        bool ICollection<Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerReference>.Contains(Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerReference item) => Wrapper.Contains(item);
        void ICollection<Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerReference>.CopyTo(Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerReference[] array, int arrayIndex) => Wrapper.CopyTo(array, arrayIndex);
        IEnumerator<Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerReference> IEnumerable<Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerReference>.GetEnumerator() => Wrapper.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Wrapper.GetEnumerator();
        bool ICollection<Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerReference>.Remove(Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Customer.ICustomerReference item) => Wrapper.Remove(item);
    }
}