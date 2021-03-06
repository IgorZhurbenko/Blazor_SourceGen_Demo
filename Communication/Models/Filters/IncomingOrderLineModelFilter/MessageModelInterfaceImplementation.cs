// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using Communication.Models.Filters.IncomingOrderLineModelFilter;
using System.Linq;
using Communication.Common;
using Google.Protobuf.Collections;
using System.Collections.Generic;
using System.Collections;
using Communication.ProtoModels.Conversion;
namespace Communication.ProtoModels
{
    public sealed partial class IncomingOrderLineModelFilterModelList : IList<Communication.Models.Filters.IncomingOrderLineModelFilter.IIncomingOrderLineModelFilterModel>
    {
        internal ListWrapper<IncomingOrderLineModelFilterModel, RepeatedField<IncomingOrderLineModelFilterModel>, IIncomingOrderLineModelFilterModel> Wrapper { get; private set; }
        public IncomingOrderLineModelFilterModelList(RepeatedField<IncomingOrderLineModelFilterModel> itemsParameter)
        {
            this.message_ = itemsParameter;
            OnConstruction();
        }
        partial void OnConstruction()
        {
            Wrapper = new ListWrapper<IncomingOrderLineModelFilterModel, RepeatedField<IncomingOrderLineModelFilterModel>, IIncomingOrderLineModelFilterModel>(Message, i => i.ToProto());
        }
        IIncomingOrderLineModelFilterModel IList<IIncomingOrderLineModelFilterModel>.this[int index] { get => Wrapper[index]; set => Wrapper[index] = value; }
        int IList<IIncomingOrderLineModelFilterModel>.IndexOf(IIncomingOrderLineModelFilterModel item) => Wrapper.IndexOf(item);
        void IList<IIncomingOrderLineModelFilterModel>.Insert(int index, IIncomingOrderLineModelFilterModel item) => Wrapper.Insert(index, item);
        void IList<IIncomingOrderLineModelFilterModel>.RemoveAt(int index) => Wrapper.RemoveAt(index);
        int ICollection<IIncomingOrderLineModelFilterModel>.Count => Wrapper.Count;
        bool ICollection<IIncomingOrderLineModelFilterModel>.IsReadOnly => Wrapper.IsReadOnly;
        void ICollection<IIncomingOrderLineModelFilterModel>.Add(IIncomingOrderLineModelFilterModel item) => Wrapper.Add(item);
        void ICollection<IIncomingOrderLineModelFilterModel>.Clear() => Wrapper.Clear();
        bool ICollection<IIncomingOrderLineModelFilterModel>.Contains(IIncomingOrderLineModelFilterModel item) => Wrapper.Contains(item);
        void ICollection<IIncomingOrderLineModelFilterModel>.CopyTo(IIncomingOrderLineModelFilterModel[] array, int arrayIndex) => Wrapper.CopyTo(array, arrayIndex);
        IEnumerator<IIncomingOrderLineModelFilterModel> IEnumerable<IIncomingOrderLineModelFilterModel>.GetEnumerator() => Wrapper.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Wrapper.GetEnumerator();
        bool ICollection<IIncomingOrderLineModelFilterModel>.Remove(IIncomingOrderLineModelFilterModel item) => Wrapper.Remove(item);
        public static implicit operator IncomingOrderLineModelFilterModelList(RepeatedField<IncomingOrderLineModelFilterModel> from)
        {
            var result = new IncomingOrderLineModelFilterModelList(from);
            return result;
        }
        public static implicit operator RepeatedField<IncomingOrderLineModelFilterModel>(IncomingOrderLineModelFilterModelList from)
        {
            return from.Message;
        }
    }
    public sealed partial class IncomingOrderLineModelFilterModel : IIncomingOrderLineModelFilterModel
    {
        Communication.Models.Filters.NumberFilter.INumberFilterModel IIncomingOrderLineModelFilterModel.Quantity
        {
            set
            {
                Quantity = value.ToProto();
            }
            get
            {
                return Quantity;
            }
        }
        Communication.Models.Filters.NumberFilter.INumberFilterModel IIncomingOrderLineModelFilterModel.Price
        {
            set
            {
                Price = value.ToProto();
            }
            get
            {
                return Price;
            }
        }
        Communication.Models.Filters.ReferenceFilter.IReferenceFilterModel IIncomingOrderLineModelFilterModel.IncomingOrder
        {
            set
            {
                IncomingOrder = value.ToProto();
            }
            get
            {
                return IncomingOrder;
            }
        }
        Communication.Models.Filters.ReferenceFilter.IReferenceFilterModel IIncomingOrderLineModelFilterModel.Good
        {
            set
            {
                Good = value.ToProto();
            }
            get
            {
                return Good;
            }
        }
    }
}