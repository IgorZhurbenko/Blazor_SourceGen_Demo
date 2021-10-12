// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using Communication.Models.Filters.DateTimeFilter;
using System.Linq;
using Communication.Common;
using Google.Protobuf.Collections;
using System.Collections.Generic;
using System.Collections;
using Communication.ProtoModels.Conversion;
namespace Communication.ProtoModels
{
    public sealed partial class DateTimeFilterModelList : IList<Communication.Models.Filters.DateTimeFilter.IDateTimeFilterModel>
    {
        internal ListWrapper<DateTimeFilterModel, RepeatedField<DateTimeFilterModel>, IDateTimeFilterModel> Wrapper { get; private set; }
        public DateTimeFilterModelList(RepeatedField<DateTimeFilterModel> itemsParameter)
        {
            this.message_ = itemsParameter;
            OnConstruction();
        }
        partial void OnConstruction()
        {
            Wrapper = new ListWrapper<DateTimeFilterModel, RepeatedField<DateTimeFilterModel>, IDateTimeFilterModel>(Message, i => i.ToProto());
        }
        IDateTimeFilterModel IList<IDateTimeFilterModel>.this[int index] { get => Wrapper[index]; set => Wrapper[index] = value; }
        int IList<IDateTimeFilterModel>.IndexOf(IDateTimeFilterModel item) => Wrapper.IndexOf(item);
        void IList<IDateTimeFilterModel>.Insert(int index, IDateTimeFilterModel item) => Wrapper.Insert(index, item);
        void IList<IDateTimeFilterModel>.RemoveAt(int index) => Wrapper.RemoveAt(index);
        int ICollection<IDateTimeFilterModel>.Count => Wrapper.Count;
        bool ICollection<IDateTimeFilterModel>.IsReadOnly => Wrapper.IsReadOnly;
        void ICollection<IDateTimeFilterModel>.Add(IDateTimeFilterModel item) => Wrapper.Add(item);
        void ICollection<IDateTimeFilterModel>.Clear() => Wrapper.Clear();
        bool ICollection<IDateTimeFilterModel>.Contains(IDateTimeFilterModel item) => Wrapper.Contains(item);
        void ICollection<IDateTimeFilterModel>.CopyTo(IDateTimeFilterModel[] array, int arrayIndex) => Wrapper.CopyTo(array, arrayIndex);
        IEnumerator<IDateTimeFilterModel> IEnumerable<IDateTimeFilterModel>.GetEnumerator() => Wrapper.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Wrapper.GetEnumerator();
        bool ICollection<IDateTimeFilterModel>.Remove(IDateTimeFilterModel item) => Wrapper.Remove(item);
        public static implicit operator DateTimeFilterModelList(RepeatedField<DateTimeFilterModel> from)
        {
            var result = new DateTimeFilterModelList(from);
            return result;
        }
        public static implicit operator RepeatedField<DateTimeFilterModel>(DateTimeFilterModelList from)
        {
            return from.Message;
        }
    }
    public sealed partial class DateTimeFilterModel : IDateTimeFilterModel
    {
        System.DateTime IDateTimeFilterModel.LeftLimit
        {
            get
            {
                return LeftLimit.ToDateTime().ToLocalTime();
            }
        }
        System.DateTime IDateTimeFilterModel.RightLimit
        {
            get
            {
                return RightLimit.ToDateTime().ToLocalTime();
            }
        }
    }
}