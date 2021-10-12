// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Supplier;
using System.Linq;
using Communication.Common;
using Google.Protobuf.Collections;
using System.Collections.Generic;
using System.Collections;
using Communication.ProtoModels.Conversion;
namespace Communication.ProtoModels
{
    public sealed partial class SupplierModelList : IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Supplier.ISupplierModel>
    {
        internal ListWrapper<SupplierModel, RepeatedField<SupplierModel>, ISupplierModel> Wrapper { get; private set; }
        public SupplierModelList(RepeatedField<SupplierModel> itemsParameter)
        {
            this.message_ = itemsParameter;
            OnConstruction();
        }
        partial void OnConstruction()
        {
            Wrapper = new ListWrapper<SupplierModel, RepeatedField<SupplierModel>, ISupplierModel>(Message, i => i.ToProto());
        }
        ISupplierModel IList<ISupplierModel>.this[int index] { get => Wrapper[index]; set => Wrapper[index] = value; }
        int IList<ISupplierModel>.IndexOf(ISupplierModel item) => Wrapper.IndexOf(item);
        void IList<ISupplierModel>.Insert(int index, ISupplierModel item) => Wrapper.Insert(index, item);
        void IList<ISupplierModel>.RemoveAt(int index) => Wrapper.RemoveAt(index);
        int ICollection<ISupplierModel>.Count => Wrapper.Count;
        bool ICollection<ISupplierModel>.IsReadOnly => Wrapper.IsReadOnly;
        void ICollection<ISupplierModel>.Add(ISupplierModel item) => Wrapper.Add(item);
        void ICollection<ISupplierModel>.Clear() => Wrapper.Clear();
        bool ICollection<ISupplierModel>.Contains(ISupplierModel item) => Wrapper.Contains(item);
        void ICollection<ISupplierModel>.CopyTo(ISupplierModel[] array, int arrayIndex) => Wrapper.CopyTo(array, arrayIndex);
        IEnumerator<ISupplierModel> IEnumerable<ISupplierModel>.GetEnumerator() => Wrapper.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Wrapper.GetEnumerator();
        bool ICollection<ISupplierModel>.Remove(ISupplierModel item) => Wrapper.Remove(item);
        public static implicit operator SupplierModelList(RepeatedField<SupplierModel> from)
        {
            var result = new SupplierModelList(from);
            return result;
        }
        public static implicit operator RepeatedField<SupplierModel>(SupplierModelList from)
        {
            return from.Message;
        }
    }
    public sealed partial class SupplierModel : ISupplierModel
    {
        ISupplierReference ISupplierModel.Reference => Reference;
    }
}