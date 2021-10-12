// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using Communication.Models.Entities.ReferrableEntities.DataHolders.Good;
using System.Linq;
using Communication.Common;
using Google.Protobuf.Collections;
using System.Collections.Generic;
using System.Collections;
using Communication.ProtoModels.Conversion;
namespace Communication.ProtoModels
{
    public sealed partial class GoodModelList : IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Good.IGoodModel>
    {
        internal ListWrapper<GoodModel, RepeatedField<GoodModel>, IGoodModel> Wrapper { get; private set; }
        public GoodModelList(RepeatedField<GoodModel> itemsParameter)
        {
            this.message_ = itemsParameter;
            OnConstruction();
        }
        partial void OnConstruction()
        {
            Wrapper = new ListWrapper<GoodModel, RepeatedField<GoodModel>, IGoodModel>(Message, i => i.ToProto());
        }
        IGoodModel IList<IGoodModel>.this[int index] { get => Wrapper[index]; set => Wrapper[index] = value; }
        int IList<IGoodModel>.IndexOf(IGoodModel item) => Wrapper.IndexOf(item);
        void IList<IGoodModel>.Insert(int index, IGoodModel item) => Wrapper.Insert(index, item);
        void IList<IGoodModel>.RemoveAt(int index) => Wrapper.RemoveAt(index);
        int ICollection<IGoodModel>.Count => Wrapper.Count;
        bool ICollection<IGoodModel>.IsReadOnly => Wrapper.IsReadOnly;
        void ICollection<IGoodModel>.Add(IGoodModel item) => Wrapper.Add(item);
        void ICollection<IGoodModel>.Clear() => Wrapper.Clear();
        bool ICollection<IGoodModel>.Contains(IGoodModel item) => Wrapper.Contains(item);
        void ICollection<IGoodModel>.CopyTo(IGoodModel[] array, int arrayIndex) => Wrapper.CopyTo(array, arrayIndex);
        IEnumerator<IGoodModel> IEnumerable<IGoodModel>.GetEnumerator() => Wrapper.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Wrapper.GetEnumerator();
        bool ICollection<IGoodModel>.Remove(IGoodModel item) => Wrapper.Remove(item);
        public static implicit operator GoodModelList(RepeatedField<GoodModel> from)
        {
            var result = new GoodModelList(from);
            return result;
        }
        public static implicit operator RepeatedField<GoodModel>(GoodModelList from)
        {
            return from.Message;
        }
    }
    public sealed partial class GoodModel : IGoodModel
    {
        IGoodReference IGoodModel.Reference => Reference;
        private IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeReference> ResponsibleEmployeesListWrapper;
        partial void OnConstruction()
        {
            ResponsibleEmployeesListWrapper = new ListWrapper<EmployeeReference, RepeatedField<EmployeeReference>, Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeReference>(ResponsibleEmployees, ri => ri.ToProto());
        }
        IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeReference> IGoodModel.ResponsibleEmployees => ResponsibleEmployeesListWrapper;
    }
}