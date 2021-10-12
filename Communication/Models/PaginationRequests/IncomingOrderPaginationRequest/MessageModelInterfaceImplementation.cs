// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using Communication.Models.PaginationRequests.IncomingOrderPaginationRequest;
using System.Linq;
using Communication.Common;
using Google.Protobuf.Collections;
using System.Collections.Generic;
using System.Collections;
using Communication.ProtoModels.Conversion;
namespace Communication.ProtoModels
{
    public sealed partial class IncomingOrderPaginationRequestModelList : IList<Communication.Models.PaginationRequests.IncomingOrderPaginationRequest.IIncomingOrderPaginationRequestModel>
    {
        internal ListWrapper<IncomingOrderPaginationRequestModel, RepeatedField<IncomingOrderPaginationRequestModel>, IIncomingOrderPaginationRequestModel> Wrapper { get; private set; }
        public IncomingOrderPaginationRequestModelList(RepeatedField<IncomingOrderPaginationRequestModel> itemsParameter)
        {
            this.message_ = itemsParameter;
            OnConstruction();
        }
        partial void OnConstruction()
        {
            Wrapper = new ListWrapper<IncomingOrderPaginationRequestModel, RepeatedField<IncomingOrderPaginationRequestModel>, IIncomingOrderPaginationRequestModel>(Message, i => i.ToProto());
        }
        IIncomingOrderPaginationRequestModel IList<IIncomingOrderPaginationRequestModel>.this[int index] { get => Wrapper[index]; set => Wrapper[index] = value; }
        int IList<IIncomingOrderPaginationRequestModel>.IndexOf(IIncomingOrderPaginationRequestModel item) => Wrapper.IndexOf(item);
        void IList<IIncomingOrderPaginationRequestModel>.Insert(int index, IIncomingOrderPaginationRequestModel item) => Wrapper.Insert(index, item);
        void IList<IIncomingOrderPaginationRequestModel>.RemoveAt(int index) => Wrapper.RemoveAt(index);
        int ICollection<IIncomingOrderPaginationRequestModel>.Count => Wrapper.Count;
        bool ICollection<IIncomingOrderPaginationRequestModel>.IsReadOnly => Wrapper.IsReadOnly;
        void ICollection<IIncomingOrderPaginationRequestModel>.Add(IIncomingOrderPaginationRequestModel item) => Wrapper.Add(item);
        void ICollection<IIncomingOrderPaginationRequestModel>.Clear() => Wrapper.Clear();
        bool ICollection<IIncomingOrderPaginationRequestModel>.Contains(IIncomingOrderPaginationRequestModel item) => Wrapper.Contains(item);
        void ICollection<IIncomingOrderPaginationRequestModel>.CopyTo(IIncomingOrderPaginationRequestModel[] array, int arrayIndex) => Wrapper.CopyTo(array, arrayIndex);
        IEnumerator<IIncomingOrderPaginationRequestModel> IEnumerable<IIncomingOrderPaginationRequestModel>.GetEnumerator() => Wrapper.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Wrapper.GetEnumerator();
        bool ICollection<IIncomingOrderPaginationRequestModel>.Remove(IIncomingOrderPaginationRequestModel item) => Wrapper.Remove(item);
        public static implicit operator IncomingOrderPaginationRequestModelList(RepeatedField<IncomingOrderPaginationRequestModel> from)
        {
            var result = new IncomingOrderPaginationRequestModelList(from);
            return result;
        }
        public static implicit operator RepeatedField<IncomingOrderPaginationRequestModel>(IncomingOrderPaginationRequestModelList from)
        {
            return from.Message;
        }
    }
    public sealed partial class IncomingOrderPaginationRequestModel : IIncomingOrderPaginationRequestModel
    {
        Communication.Models.Filters.IncomingOrderModelFilter.IIncomingOrderModelFilterModel IIncomingOrderPaginationRequestModel.Filter
        {
            set
            {
                Filter = value.ToProto();
            }
            get
            {
                return Filter;
            }
        }
    }
}