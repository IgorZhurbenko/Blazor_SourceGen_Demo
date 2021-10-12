// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using System.Linq;
using Communication.Common;
using Google.Protobuf.Collections;
using System.Collections.Generic;
using Communication.ProtoModels.Conversion;
using System.Collections;
using Communication.Models.Entities.ReferrableEntities.DataHolders.Good;
namespace Communication.ProtoModels
{
    public sealed partial class GoodReference : Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference
    {
        public static implicit operator GoodReferenceMessage(GoodReference message)
        {
            return new()
            {Message = message};
        }
        public static implicit operator GoodReference(GoodReferenceMessage message)
        {
            return message.Message;
        }
    }
    public sealed partial class GoodReferenceList : IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference>
    {
        internal ListWrapper<GoodReference, RepeatedField<GoodReference>, IGoodReference> Wrapper { get; private set; }
        public GoodReferenceList(RepeatedField<GoodReference> itemsParameter)
        {
            message_ = itemsParameter;
            OnConstruction();
        }
        partial void OnConstruction()
        {
            Wrapper = new ListWrapper<GoodReference, RepeatedField<GoodReference>, IGoodReference>(Message, i => i.ToProto());
        }
        Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference>.this[int index] { get => Wrapper[index]; set => Wrapper[index] = value; }
        int IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference>.IndexOf(Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference item) => Wrapper.IndexOf(item);
        void IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference>.Insert(int index, Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference item) => Wrapper.Insert(index, item);
        void IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference>.RemoveAt(int index) => Wrapper.RemoveAt(index);
        int ICollection<Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference>.Count => Wrapper.Count;
        bool ICollection<Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference>.IsReadOnly => Wrapper.IsReadOnly;
        void ICollection<Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference>.Add(Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference item) => Wrapper.Add(item);
        void ICollection<Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference>.Clear() => Wrapper.Clear();
        bool ICollection<Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference>.Contains(Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference item) => Wrapper.Contains(item);
        void ICollection<Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference>.CopyTo(Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference[] array, int arrayIndex) => Wrapper.CopyTo(array, arrayIndex);
        IEnumerator<Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference> IEnumerable<Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference>.GetEnumerator() => Wrapper.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Wrapper.GetEnumerator();
        bool ICollection<Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference>.Remove(Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodReference item) => Wrapper.Remove(item);
    }
}