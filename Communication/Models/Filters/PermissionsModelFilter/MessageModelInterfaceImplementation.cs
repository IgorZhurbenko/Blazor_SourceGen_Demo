// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using Communication.Models.Filters.PermissionsModelFilter;
using System.Linq;
using Communication.Common;
using Google.Protobuf.Collections;
using System.Collections.Generic;
using System.Collections;
using Communication.ProtoModels.Conversion;
namespace Communication.ProtoModels
{
    public sealed partial class PermissionsModelFilterModelList : IList<Communication.Models.Filters.PermissionsModelFilter.IPermissionsModelFilterModel>
    {
        internal ListWrapper<PermissionsModelFilterModel, RepeatedField<PermissionsModelFilterModel>, IPermissionsModelFilterModel> Wrapper { get; private set; }
        public PermissionsModelFilterModelList(RepeatedField<PermissionsModelFilterModel> itemsParameter)
        {
            this.message_ = itemsParameter;
            OnConstruction();
        }
        partial void OnConstruction()
        {
            Wrapper = new ListWrapper<PermissionsModelFilterModel, RepeatedField<PermissionsModelFilterModel>, IPermissionsModelFilterModel>(Message, i => i.ToProto());
        }
        IPermissionsModelFilterModel IList<IPermissionsModelFilterModel>.this[int index] { get => Wrapper[index]; set => Wrapper[index] = value; }
        int IList<IPermissionsModelFilterModel>.IndexOf(IPermissionsModelFilterModel item) => Wrapper.IndexOf(item);
        void IList<IPermissionsModelFilterModel>.Insert(int index, IPermissionsModelFilterModel item) => Wrapper.Insert(index, item);
        void IList<IPermissionsModelFilterModel>.RemoveAt(int index) => Wrapper.RemoveAt(index);
        int ICollection<IPermissionsModelFilterModel>.Count => Wrapper.Count;
        bool ICollection<IPermissionsModelFilterModel>.IsReadOnly => Wrapper.IsReadOnly;
        void ICollection<IPermissionsModelFilterModel>.Add(IPermissionsModelFilterModel item) => Wrapper.Add(item);
        void ICollection<IPermissionsModelFilterModel>.Clear() => Wrapper.Clear();
        bool ICollection<IPermissionsModelFilterModel>.Contains(IPermissionsModelFilterModel item) => Wrapper.Contains(item);
        void ICollection<IPermissionsModelFilterModel>.CopyTo(IPermissionsModelFilterModel[] array, int arrayIndex) => Wrapper.CopyTo(array, arrayIndex);
        IEnumerator<IPermissionsModelFilterModel> IEnumerable<IPermissionsModelFilterModel>.GetEnumerator() => Wrapper.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Wrapper.GetEnumerator();
        bool ICollection<IPermissionsModelFilterModel>.Remove(IPermissionsModelFilterModel item) => Wrapper.Remove(item);
        public static implicit operator PermissionsModelFilterModelList(RepeatedField<PermissionsModelFilterModel> from)
        {
            var result = new PermissionsModelFilterModelList(from);
            return result;
        }
        public static implicit operator RepeatedField<PermissionsModelFilterModel>(PermissionsModelFilterModelList from)
        {
            return from.Message;
        }
    }
    public sealed partial class PermissionsModelFilterModel : IPermissionsModelFilterModel
    {
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.UserAdd
        {
            set
            {
                UserAdd = value.ToProto();
            }
            get
            {
                return UserAdd;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.UserEdit
        {
            set
            {
                UserEdit = value.ToProto();
            }
            get
            {
                return UserEdit;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.UserDelete
        {
            set
            {
                UserDelete = value.ToProto();
            }
            get
            {
                return UserDelete;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.UserRead
        {
            set
            {
                UserRead = value.ToProto();
            }
            get
            {
                return UserRead;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.UserSee
        {
            set
            {
                UserSee = value.ToProto();
            }
            get
            {
                return UserSee;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.CustomerAdd
        {
            set
            {
                CustomerAdd = value.ToProto();
            }
            get
            {
                return CustomerAdd;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.CustomerEdit
        {
            set
            {
                CustomerEdit = value.ToProto();
            }
            get
            {
                return CustomerEdit;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.CustomerDelete
        {
            set
            {
                CustomerDelete = value.ToProto();
            }
            get
            {
                return CustomerDelete;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.CustomerRead
        {
            set
            {
                CustomerRead = value.ToProto();
            }
            get
            {
                return CustomerRead;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.CustomerSee
        {
            set
            {
                CustomerSee = value.ToProto();
            }
            get
            {
                return CustomerSee;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.SupplierAdd
        {
            set
            {
                SupplierAdd = value.ToProto();
            }
            get
            {
                return SupplierAdd;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.SupplierEdit
        {
            set
            {
                SupplierEdit = value.ToProto();
            }
            get
            {
                return SupplierEdit;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.SupplierDelete
        {
            set
            {
                SupplierDelete = value.ToProto();
            }
            get
            {
                return SupplierDelete;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.SupplierRead
        {
            set
            {
                SupplierRead = value.ToProto();
            }
            get
            {
                return SupplierRead;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.SupplierSee
        {
            set
            {
                SupplierSee = value.ToProto();
            }
            get
            {
                return SupplierSee;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.GoodAdd
        {
            set
            {
                GoodAdd = value.ToProto();
            }
            get
            {
                return GoodAdd;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.GoodEdit
        {
            set
            {
                GoodEdit = value.ToProto();
            }
            get
            {
                return GoodEdit;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.GoodDelete
        {
            set
            {
                GoodDelete = value.ToProto();
            }
            get
            {
                return GoodDelete;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.GoodRead
        {
            set
            {
                GoodRead = value.ToProto();
            }
            get
            {
                return GoodRead;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.GoodSee
        {
            set
            {
                GoodSee = value.ToProto();
            }
            get
            {
                return GoodSee;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.EmployeeAdd
        {
            set
            {
                EmployeeAdd = value.ToProto();
            }
            get
            {
                return EmployeeAdd;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.EmployeeEdit
        {
            set
            {
                EmployeeEdit = value.ToProto();
            }
            get
            {
                return EmployeeEdit;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.EmployeeDelete
        {
            set
            {
                EmployeeDelete = value.ToProto();
            }
            get
            {
                return EmployeeDelete;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.EmployeeRead
        {
            set
            {
                EmployeeRead = value.ToProto();
            }
            get
            {
                return EmployeeRead;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.EmployeeSee
        {
            set
            {
                EmployeeSee = value.ToProto();
            }
            get
            {
                return EmployeeSee;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.IncomingOrderMove
        {
            set
            {
                IncomingOrderMove = value.ToProto();
            }
            get
            {
                return IncomingOrderMove;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.IncomingOrderAdd
        {
            set
            {
                IncomingOrderAdd = value.ToProto();
            }
            get
            {
                return IncomingOrderAdd;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.IncomingOrderEdit
        {
            set
            {
                IncomingOrderEdit = value.ToProto();
            }
            get
            {
                return IncomingOrderEdit;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.IncomingOrderDelete
        {
            set
            {
                IncomingOrderDelete = value.ToProto();
            }
            get
            {
                return IncomingOrderDelete;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.IncomingOrderRead
        {
            set
            {
                IncomingOrderRead = value.ToProto();
            }
            get
            {
                return IncomingOrderRead;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.IncomingOrderSee
        {
            set
            {
                IncomingOrderSee = value.ToProto();
            }
            get
            {
                return IncomingOrderSee;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.OutcomingOrderMove
        {
            set
            {
                OutcomingOrderMove = value.ToProto();
            }
            get
            {
                return OutcomingOrderMove;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.OutcomingOrderAdd
        {
            set
            {
                OutcomingOrderAdd = value.ToProto();
            }
            get
            {
                return OutcomingOrderAdd;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.OutcomingOrderEdit
        {
            set
            {
                OutcomingOrderEdit = value.ToProto();
            }
            get
            {
                return OutcomingOrderEdit;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.OutcomingOrderDelete
        {
            set
            {
                OutcomingOrderDelete = value.ToProto();
            }
            get
            {
                return OutcomingOrderDelete;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.OutcomingOrderRead
        {
            set
            {
                OutcomingOrderRead = value.ToProto();
            }
            get
            {
                return OutcomingOrderRead;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.OutcomingOrderSee
        {
            set
            {
                OutcomingOrderSee = value.ToProto();
            }
            get
            {
                return OutcomingOrderSee;
            }
        }
        Communication.Models.Filters.BooleanFilter.IBooleanFilterModel IPermissionsModelFilterModel.TechnicalAdministrating
        {
            set
            {
                TechnicalAdministrating = value.ToProto();
            }
            get
            {
                return TechnicalAdministrating;
            }
        }
    }
}