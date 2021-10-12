// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using Communication.Models.Filters.IncomingOrderModelFilter;
using System.Linq;
using Communication.Common;
using Google.Protobuf.Collections;
using System.Collections.Generic;
using System.Collections;
using Communication.ProtoModels.Conversion;
namespace Communication.ProtoModels
{
    public sealed partial class IncomingOrderModelFilterModelList : IList<Communication.Models.Filters.IncomingOrderModelFilter.IIncomingOrderModelFilterModel>
    {
        internal ListWrapper<IncomingOrderModelFilterModel, RepeatedField<IncomingOrderModelFilterModel>, IIncomingOrderModelFilterModel> Wrapper { get; private set; }
        public IncomingOrderModelFilterModelList(RepeatedField<IncomingOrderModelFilterModel> itemsParameter)
        {
            this.message_ = itemsParameter;
            OnConstruction();
        }
        partial void OnConstruction()
        {
            Wrapper = new ListWrapper<IncomingOrderModelFilterModel, RepeatedField<IncomingOrderModelFilterModel>, IIncomingOrderModelFilterModel>(Message, i => i.ToProto());
        }
        IIncomingOrderModelFilterModel IList<IIncomingOrderModelFilterModel>.this[int index] { get => Wrapper[index]; set => Wrapper[index] = value; }
        int IList<IIncomingOrderModelFilterModel>.IndexOf(IIncomingOrderModelFilterModel item) => Wrapper.IndexOf(item);
        void IList<IIncomingOrderModelFilterModel>.Insert(int index, IIncomingOrderModelFilterModel item) => Wrapper.Insert(index, item);
        void IList<IIncomingOrderModelFilterModel>.RemoveAt(int index) => Wrapper.RemoveAt(index);
        int ICollection<IIncomingOrderModelFilterModel>.Count => Wrapper.Count;
        bool ICollection<IIncomingOrderModelFilterModel>.IsReadOnly => Wrapper.IsReadOnly;
        void ICollection<IIncomingOrderModelFilterModel>.Add(IIncomingOrderModelFilterModel item) => Wrapper.Add(item);
        void ICollection<IIncomingOrderModelFilterModel>.Clear() => Wrapper.Clear();
        bool ICollection<IIncomingOrderModelFilterModel>.Contains(IIncomingOrderModelFilterModel item) => Wrapper.Contains(item);
        void ICollection<IIncomingOrderModelFilterModel>.CopyTo(IIncomingOrderModelFilterModel[] array, int arrayIndex) => Wrapper.CopyTo(array, arrayIndex);
        IEnumerator<IIncomingOrderModelFilterModel> IEnumerable<IIncomingOrderModelFilterModel>.GetEnumerator() => Wrapper.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Wrapper.GetEnumerator();
        bool ICollection<IIncomingOrderModelFilterModel>.Remove(IIncomingOrderModelFilterModel item) => Wrapper.Remove(item);
        public static implicit operator IncomingOrderModelFilterModelList(RepeatedField<IncomingOrderModelFilterModel> from)
        {
            var result = new IncomingOrderModelFilterModelList(from);
            return result;
        }
        public static implicit operator RepeatedField<IncomingOrderModelFilterModel>(IncomingOrderModelFilterModelList from)
        {
            return from.Message;
        }
    }
    public sealed partial class IncomingOrderModelFilterModel : IIncomingOrderModelFilterModel
    {
        Communication.Models.Filters.StringFilter.IStringFilterModel IIncomingOrderModelFilterModel.Number
        {
            set
            {
                Number = value.ToProto();
            }
            get
            {
                return Number;
            }
        }
        Communication.Models.Filters.ReferenceFilter.IReferenceFilterModel IIncomingOrderModelFilterModel.Reference
        {
            set
            {
                Reference = value.ToProto();
            }
            get
            {
                return Reference;
            }
        }
        Communication.Models.Filters.CollectionFilter.ICollectionFilterModel IIncomingOrderModelFilterModel.RequestedGoods
        {
            set
            {
                RequestedGoods = value.ToProto();
            }
            get
            {
                return RequestedGoods;
            }
        }
    }
}