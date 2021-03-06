// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using Communication.Models.Filters.BooleanFilter;
using System.Linq;
using Communication.Common;
using Google.Protobuf.Collections;
using System.Collections.Generic;
using System.Collections;
using Communication.ProtoModels.Conversion;
namespace Communication.ProtoModels
{
    public sealed partial class BooleanFilterModelList : IList<Communication.Models.Filters.BooleanFilter.IBooleanFilterModel>
    {
        internal ListWrapper<BooleanFilterModel, RepeatedField<BooleanFilterModel>, IBooleanFilterModel> Wrapper { get; private set; }
        public BooleanFilterModelList(RepeatedField<BooleanFilterModel> itemsParameter)
        {
            this.message_ = itemsParameter;
            OnConstruction();
        }
        partial void OnConstruction()
        {
            Wrapper = new ListWrapper<BooleanFilterModel, RepeatedField<BooleanFilterModel>, IBooleanFilterModel>(Message, i => i.ToProto());
        }
        IBooleanFilterModel IList<IBooleanFilterModel>.this[int index] { get => Wrapper[index]; set => Wrapper[index] = value; }
        int IList<IBooleanFilterModel>.IndexOf(IBooleanFilterModel item) => Wrapper.IndexOf(item);
        void IList<IBooleanFilterModel>.Insert(int index, IBooleanFilterModel item) => Wrapper.Insert(index, item);
        void IList<IBooleanFilterModel>.RemoveAt(int index) => Wrapper.RemoveAt(index);
        int ICollection<IBooleanFilterModel>.Count => Wrapper.Count;
        bool ICollection<IBooleanFilterModel>.IsReadOnly => Wrapper.IsReadOnly;
        void ICollection<IBooleanFilterModel>.Add(IBooleanFilterModel item) => Wrapper.Add(item);
        void ICollection<IBooleanFilterModel>.Clear() => Wrapper.Clear();
        bool ICollection<IBooleanFilterModel>.Contains(IBooleanFilterModel item) => Wrapper.Contains(item);
        void ICollection<IBooleanFilterModel>.CopyTo(IBooleanFilterModel[] array, int arrayIndex) => Wrapper.CopyTo(array, arrayIndex);
        IEnumerator<IBooleanFilterModel> IEnumerable<IBooleanFilterModel>.GetEnumerator() => Wrapper.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Wrapper.GetEnumerator();
        bool ICollection<IBooleanFilterModel>.Remove(IBooleanFilterModel item) => Wrapper.Remove(item);
        public static implicit operator BooleanFilterModelList(RepeatedField<BooleanFilterModel> from)
        {
            var result = new BooleanFilterModelList(from);
            return result;
        }
        public static implicit operator RepeatedField<BooleanFilterModel>(BooleanFilterModelList from)
        {
            return from.Message;
        }
    }
    public sealed partial class BooleanFilterModel : IBooleanFilterModel
    {
    }
}