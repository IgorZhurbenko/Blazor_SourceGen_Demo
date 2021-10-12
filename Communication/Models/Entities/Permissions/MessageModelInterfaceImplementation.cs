// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using Communication.Models.Entities.Permissions;
using System.Linq;
using Communication.Common;
using Google.Protobuf.Collections;
using System.Collections.Generic;
using System.Collections;
using Communication.ProtoModels.Conversion;
namespace Communication.ProtoModels
{
    public sealed partial class PermissionsModelList : IList<Communication.Models.Entities.Permissions.IPermissionsModel>
    {
        internal ListWrapper<PermissionsModel, RepeatedField<PermissionsModel>, IPermissionsModel> Wrapper { get; private set; }
        public PermissionsModelList(RepeatedField<PermissionsModel> itemsParameter)
        {
            this.message_ = itemsParameter;
            OnConstruction();
        }
        partial void OnConstruction()
        {
            Wrapper = new ListWrapper<PermissionsModel, RepeatedField<PermissionsModel>, IPermissionsModel>(Message, i => i.ToProto());
        }
        IPermissionsModel IList<IPermissionsModel>.this[int index] { get => Wrapper[index]; set => Wrapper[index] = value; }
        int IList<IPermissionsModel>.IndexOf(IPermissionsModel item) => Wrapper.IndexOf(item);
        void IList<IPermissionsModel>.Insert(int index, IPermissionsModel item) => Wrapper.Insert(index, item);
        void IList<IPermissionsModel>.RemoveAt(int index) => Wrapper.RemoveAt(index);
        int ICollection<IPermissionsModel>.Count => Wrapper.Count;
        bool ICollection<IPermissionsModel>.IsReadOnly => Wrapper.IsReadOnly;
        void ICollection<IPermissionsModel>.Add(IPermissionsModel item) => Wrapper.Add(item);
        void ICollection<IPermissionsModel>.Clear() => Wrapper.Clear();
        bool ICollection<IPermissionsModel>.Contains(IPermissionsModel item) => Wrapper.Contains(item);
        void ICollection<IPermissionsModel>.CopyTo(IPermissionsModel[] array, int arrayIndex) => Wrapper.CopyTo(array, arrayIndex);
        IEnumerator<IPermissionsModel> IEnumerable<IPermissionsModel>.GetEnumerator() => Wrapper.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Wrapper.GetEnumerator();
        bool ICollection<IPermissionsModel>.Remove(IPermissionsModel item) => Wrapper.Remove(item);
        public static implicit operator PermissionsModelList(RepeatedField<PermissionsModel> from)
        {
            var result = new PermissionsModelList(from);
            return result;
        }
        public static implicit operator RepeatedField<PermissionsModel>(PermissionsModelList from)
        {
            return from.Message;
        }
    }
    public sealed partial class PermissionsModel : IPermissionsModel
    {
    }
}