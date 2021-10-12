// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using Communication.Models.PaginationRequests.IncomingOrderLinePaginationRequest;
using System.Linq;
using Communication.Common;
using Google.Protobuf.Collections;
using System.Collections.Generic;
using System.Collections;
using Communication.ProtoModels.Conversion;
namespace Communication.ProtoModels
{
    public sealed partial class IncomingOrderLinePaginationRequestModelList : IList<Communication.Models.PaginationRequests.IncomingOrderLinePaginationRequest.IIncomingOrderLinePaginationRequestModel>
    {
        internal ListWrapper<IncomingOrderLinePaginationRequestModel, RepeatedField<IncomingOrderLinePaginationRequestModel>, IIncomingOrderLinePaginationRequestModel> Wrapper { get; private set; }
        public IncomingOrderLinePaginationRequestModelList(RepeatedField<IncomingOrderLinePaginationRequestModel> itemsParameter)
        {
            this.message_ = itemsParameter;
            OnConstruction();
        }
        partial void OnConstruction()
        {
            Wrapper = new ListWrapper<IncomingOrderLinePaginationRequestModel, RepeatedField<IncomingOrderLinePaginationRequestModel>, IIncomingOrderLinePaginationRequestModel>(Message, i => i.ToProto());
        }
        IIncomingOrderLinePaginationRequestModel IList<IIncomingOrderLinePaginationRequestModel>.this[int index] { get => Wrapper[index]; set => Wrapper[index] = value; }
        int IList<IIncomingOrderLinePaginationRequestModel>.IndexOf(IIncomingOrderLinePaginationRequestModel item) => Wrapper.IndexOf(item);
        void IList<IIncomingOrderLinePaginationRequestModel>.Insert(int index, IIncomingOrderLinePaginationRequestModel item) => Wrapper.Insert(index, item);
        void IList<IIncomingOrderLinePaginationRequestModel>.RemoveAt(int index) => Wrapper.RemoveAt(index);
        int ICollection<IIncomingOrderLinePaginationRequestModel>.Count => Wrapper.Count;
        bool ICollection<IIncomingOrderLinePaginationRequestModel>.IsReadOnly => Wrapper.IsReadOnly;
        void ICollection<IIncomingOrderLinePaginationRequestModel>.Add(IIncomingOrderLinePaginationRequestModel item) => Wrapper.Add(item);
        void ICollection<IIncomingOrderLinePaginationRequestModel>.Clear() => Wrapper.Clear();
        bool ICollection<IIncomingOrderLinePaginationRequestModel>.Contains(IIncomingOrderLinePaginationRequestModel item) => Wrapper.Contains(item);
        void ICollection<IIncomingOrderLinePaginationRequestModel>.CopyTo(IIncomingOrderLinePaginationRequestModel[] array, int arrayIndex) => Wrapper.CopyTo(array, arrayIndex);
        IEnumerator<IIncomingOrderLinePaginationRequestModel> IEnumerable<IIncomingOrderLinePaginationRequestModel>.GetEnumerator() => Wrapper.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Wrapper.GetEnumerator();
        bool ICollection<IIncomingOrderLinePaginationRequestModel>.Remove(IIncomingOrderLinePaginationRequestModel item) => Wrapper.Remove(item);
        public static implicit operator IncomingOrderLinePaginationRequestModelList(RepeatedField<IncomingOrderLinePaginationRequestModel> from)
        {
            var result = new IncomingOrderLinePaginationRequestModelList(from);
            return result;
        }
        public static implicit operator RepeatedField<IncomingOrderLinePaginationRequestModel>(IncomingOrderLinePaginationRequestModelList from)
        {
            return from.Message;
        }
    }
    public sealed partial class IncomingOrderLinePaginationRequestModel : IIncomingOrderLinePaginationRequestModel
    {
        Communication.Models.Filters.IncomingOrderLineModelFilter.IIncomingOrderLineModelFilterModel IIncomingOrderLinePaginationRequestModel.Filter
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