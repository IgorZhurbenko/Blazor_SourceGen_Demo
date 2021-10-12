// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using System.Linq;
using Communication.Common;
using Google.Protobuf.Collections;
using System.Collections.Generic;
using Communication.ProtoModels.Conversion;
using System.Collections;
using Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder;
namespace Communication.ProtoModels
{
    public sealed partial class OutcomingOrderReference : Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference
    {
        public static implicit operator OutcomingOrderReferenceMessage(OutcomingOrderReference message)
        {
            return new()
            {Message = message};
        }
        public static implicit operator OutcomingOrderReference(OutcomingOrderReferenceMessage message)
        {
            return message.Message;
        }
    }
    public sealed partial class OutcomingOrderReferenceList : IList<Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference>
    {
        internal ListWrapper<OutcomingOrderReference, RepeatedField<OutcomingOrderReference>, IOutcomingOrderReference> Wrapper { get; private set; }
        public OutcomingOrderReferenceList(RepeatedField<OutcomingOrderReference> itemsParameter)
        {
            message_ = itemsParameter;
            OnConstruction();
        }
        partial void OnConstruction()
        {
            Wrapper = new ListWrapper<OutcomingOrderReference, RepeatedField<OutcomingOrderReference>, IOutcomingOrderReference>(Message, i => i.ToProto());
        }
        Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference IList<Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference>.this[int index] { get => Wrapper[index]; set => Wrapper[index] = value; }
        int IList<Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference>.IndexOf(Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference item) => Wrapper.IndexOf(item);
        void IList<Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference>.Insert(int index, Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference item) => Wrapper.Insert(index, item);
        void IList<Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference>.RemoveAt(int index) => Wrapper.RemoveAt(index);
        int ICollection<Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference>.Count => Wrapper.Count;
        bool ICollection<Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference>.IsReadOnly => Wrapper.IsReadOnly;
        void ICollection<Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference>.Add(Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference item) => Wrapper.Add(item);
        void ICollection<Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference>.Clear() => Wrapper.Clear();
        bool ICollection<Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference>.Contains(Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference item) => Wrapper.Contains(item);
        void ICollection<Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference>.CopyTo(Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference[] array, int arrayIndex) => Wrapper.CopyTo(array, arrayIndex);
        IEnumerator<Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference> IEnumerable<Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference>.GetEnumerator() => Wrapper.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Wrapper.GetEnumerator();
        bool ICollection<Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference>.Remove(Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.IOutcomingOrderReference item) => Wrapper.Remove(item);
    }
}