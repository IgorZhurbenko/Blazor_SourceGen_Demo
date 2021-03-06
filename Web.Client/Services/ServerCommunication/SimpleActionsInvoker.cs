// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using System.Collections.Generic;
using System;
using System.Linq;
using Communication.ProtoModels.Conversion;
using Communication.ProtoServices;
using Communication.ProtoModels;
using Google.Protobuf.WellKnownTypes;
using System.Threading.Tasks;
using Communication.Exceptions;
using Web.Client.Services;
using Common.Actions;
using Communication;
namespace Web.Client.Services.ServerCommunication
{
    public class SimpleActionsInvoker
    {
        readonly Communication.ProtoServices.SimpleActions.SimpleActionsClient _client;
        public SimpleActionsInvoker(Communication.ProtoServices.SimpleActions.SimpleActionsClient client)
        {
            _client = client;
            GetOneEmployee = new(_client);
            GetSeveralEmployees = new(_client);
            GetSorted = new(_client);
            IsEvenCollection = new(_client);
            ThrowException = new(_client);
            ReturnSameFilter = new(_client);
            ReturnThreadID = new(_client);
        }
        public GetOneEmployeeAction GetOneEmployee { get; }
        public class GetOneEmployeeAction
        {
            readonly Communication.ProtoServices.SimpleActions.SimpleActionsClient _client;
            AsynchronousActionDispatcher<bool, IServerResponse<System.Collections.Generic.IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeModel>>> Manager { get; }
            public GetOneEmployeeAction(Communication.ProtoServices.SimpleActions.SimpleActionsClient client)
            {
                _client = client;
                Manager = new(new()
                {ID = 7, CacheValidityPeriodSeconds = 0, ActionsStoreCapacity = 0, Name = "GetOneEmployee", CompareParameters = (param1, param2) => param1.Equals(param2), MainAction = async request =>
                {
                    var protoParam = new Empty();
                    return await _client.GetOneEmployeeAsync(protoParam, new Grpc.Core.Metadata{new Grpc.Core.Metadata.Entry("SessionKey", Account.SessionKey ?? "")});
                }});
            }
            /// <summary>
            /// Returns last result of invocation with same parameters if in cache and not expired. Otherwise invokes server action, puts it to cache and returns the result.
            /// </summary>
            public async Task<System.Collections.Generic.IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeModel>> GetResultAsync()
            {
                return await ClientCommonPipelines.InvokeServerAction<bool, System.Collections.Generic.IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeModel>>(() => Manager.InvokeAsync(false));
            }
            public void InvalidateAllCache()
            {
                Manager.InvalidateCache();
            }
        }
        public GetSeveralEmployeesAction GetSeveralEmployees { get; }
        public class GetSeveralEmployeesAction
        {
            readonly Communication.ProtoServices.SimpleActions.SimpleActionsClient _client;
            AsynchronousActionDispatcher<uint, IServerResponse<System.Collections.Generic.IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeModel>>> Manager { get; }
            public GetSeveralEmployeesAction(Communication.ProtoServices.SimpleActions.SimpleActionsClient client)
            {
                _client = client;
                Manager = new(new()
                {ID = 8, CacheValidityPeriodSeconds = 0, ActionsStoreCapacity = 0, Name = "GetSeveralEmployees", CompareParameters = (param1, param2) => param1.Equals(param2), MainAction = async request =>
                {
                    var protoParam = request.ToProto();
                    return await _client.GetSeveralEmployeesAsync(protoParam, new Grpc.Core.Metadata{new Grpc.Core.Metadata.Entry("SessionKey", Account.SessionKey ?? "")});
                }});
            }
            /// <summary>
            /// Returns last result of invocation with same parameters if in cache and not expired. Otherwise invokes server action, puts it to cache and returns the result.
            /// </summary>
            public async Task<System.Collections.Generic.IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeModel>> GetResultAsync(uint request)
            {
                var payload = request;
                var result = await ClientCommonPipelines.InvokeServerAction<uint, System.Collections.Generic.IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeModel>>(() => Manager.InvokeAsync(payload));
                return result;
            }
            public void InvalidateAllCache()
            {
                Manager.InvalidateCache();
            }
        }
        public GetSortedAction GetSorted { get; }
        public class GetSortedAction
        {
            readonly Communication.ProtoServices.SimpleActions.SimpleActionsClient _client;
            AsynchronousActionDispatcher<System.Collections.Generic.IEnumerable<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeModel>, IServerResponse<System.Collections.Generic.IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeModel>>> Manager { get; }
            public GetSortedAction(Communication.ProtoServices.SimpleActions.SimpleActionsClient client)
            {
                _client = client;
                Manager = new(new()
                {ID = 9, CacheValidityPeriodSeconds = 0, ActionsStoreCapacity = 0, Name = "GetSorted", CompareParameters = (param1, param2) => param1.Equals(param2), MainAction = async request =>
                {
                    var protoParam = new Communication.ProtoModels.EmployeeModelListMessage(request.ToProto());
                    return await _client.GetSortedAsync(protoParam, new Grpc.Core.Metadata{new Grpc.Core.Metadata.Entry("SessionKey", Account.SessionKey ?? "")});
                }});
            }
            /// <summary>
            /// Returns last result of invocation with same parameters if in cache and not expired. Otherwise invokes server action, puts it to cache and returns the result.
            /// </summary>
            public async Task<System.Collections.Generic.IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeModel>> GetResultAsync(System.Collections.Generic.IEnumerable<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeModel> request)
            {
                var payload = request;
                var result = await ClientCommonPipelines.InvokeServerAction<System.Collections.Generic.IEnumerable<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeModel>, System.Collections.Generic.IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeModel>>(() => Manager.InvokeAsync(payload));
                return result;
            }
            public void InvalidateAllCache()
            {
                Manager.InvalidateCache();
            }
        }
        public IsEvenCollectionAction IsEvenCollection { get; }
        public class IsEvenCollectionAction
        {
            readonly Communication.ProtoServices.SimpleActions.SimpleActionsClient _client;
            AsynchronousActionDispatcher<System.Collections.Generic.IEnumerable<string>, IServerResponse<System.Boolean>> Manager { get; }
            public IsEvenCollectionAction(Communication.ProtoServices.SimpleActions.SimpleActionsClient client)
            {
                _client = client;
                Manager = new(new()
                {ID = 10, CacheValidityPeriodSeconds = 0, ActionsStoreCapacity = 0, Name = "IsEvenCollection", CompareParameters = (param1, param2) => param1.Equals(param2), MainAction = async request =>
                {
                    var protoParam = new StringListMessage(request.ToProto());
                    return await _client.IsEvenCollectionAsync(protoParam, new Grpc.Core.Metadata{new Grpc.Core.Metadata.Entry("SessionKey", Account.SessionKey ?? "")});
                }});
            }
            /// <summary>
            /// Returns last result of invocation with same parameters if in cache and not expired. Otherwise invokes server action, puts it to cache and returns the result.
            /// </summary>
            public async Task<System.Boolean> GetResultAsync(System.Collections.Generic.ICollection<string> request)
            {
                var payload = request;
                var result = await ClientCommonPipelines.InvokeServerAction<System.Collections.Generic.ICollection<string>, System.Boolean>(() => Manager.InvokeAsync(payload));
                return result;
            }
            public void InvalidateAllCache()
            {
                Manager.InvalidateCache();
            }
        }
        public ThrowExceptionAction ThrowException { get; }
        public class ThrowExceptionAction
        {
            readonly Communication.ProtoServices.SimpleActions.SimpleActionsClient _client;
            AsynchronousActionDispatcher<string, IServerResponse<System.Boolean>> Manager { get; }
            public ThrowExceptionAction(Communication.ProtoServices.SimpleActions.SimpleActionsClient client)
            {
                _client = client;
                Manager = new(new()
                {ID = 11, CacheValidityPeriodSeconds = 0, ActionsStoreCapacity = 0, Name = "ThrowException", CompareParameters = (param1, param2) => param1.Equals(param2), MainAction = async exceptionMessage =>
                {
                    var protoParam = exceptionMessage.ToProto();
                    return await _client.ThrowExceptionAsync(protoParam, new Grpc.Core.Metadata{new Grpc.Core.Metadata.Entry("SessionKey", Account.SessionKey ?? "")});
                }});
            }
            /// <summary>
            /// Returns last result of invocation with same parameters if in cache and not expired. Otherwise invokes server action, puts it to cache and returns the result.
            /// </summary>
            public async Task<System.Boolean> GetResultAsync(string exceptionMessage)
            {
                var payload = exceptionMessage;
                var result = await ClientCommonPipelines.InvokeServerAction<string, System.Boolean>(() => Manager.InvokeAsync(payload));
                return result;
            }
            public void InvalidateAllCache()
            {
                Manager.InvalidateCache();
            }
        }
        public ReturnSameFilterAction ReturnSameFilter { get; }
        public class ReturnSameFilterAction
        {
            readonly Communication.ProtoServices.SimpleActions.SimpleActionsClient _client;
            AsynchronousActionDispatcher<Communication.Models.Filters.EmployeeModelFilter.IEmployeeModelFilterModel, IServerResponse<Communication.Models.Filters.EmployeeModelFilter.IEmployeeModelFilterModel>> Manager { get; }
            public ReturnSameFilterAction(Communication.ProtoServices.SimpleActions.SimpleActionsClient client)
            {
                _client = client;
                Manager = new(new()
                {ID = 12, CacheValidityPeriodSeconds = 0, ActionsStoreCapacity = 0, Name = "ReturnSameFilter", CompareParameters = (param1, param2) => param1.Equals(param2), MainAction = async incomingFilter =>
                {
                    var protoParam = new Communication.ProtoModels.EmployeeModelFilterModelMessage(incomingFilter.ToProto());
                    return await _client.ReturnSameFilterAsync(protoParam, new Grpc.Core.Metadata{new Grpc.Core.Metadata.Entry("SessionKey", Account.SessionKey ?? "")});
                }});
            }
            /// <summary>
            /// Returns last result of invocation with same parameters if in cache and not expired. Otherwise invokes server action, puts it to cache and returns the result.
            /// </summary>
            public async Task<Communication.Models.Filters.EmployeeModelFilter.IEmployeeModelFilterModel> GetResultAsync(Communication.Models.Filters.EmployeeModelFilter.IEmployeeModelFilterModel incomingFilter)
            {
                var payload = incomingFilter;
                var result = await ClientCommonPipelines.InvokeServerAction<Communication.Models.Filters.EmployeeModelFilter.IEmployeeModelFilterModel, Communication.Models.Filters.EmployeeModelFilter.IEmployeeModelFilterModel>(() => Manager.InvokeAsync(payload));
                return result;
            }
            public void InvalidateAllCache()
            {
                Manager.InvalidateCache();
            }
        }
        public ReturnThreadIDAction ReturnThreadID { get; }
        public class ReturnThreadIDAction
        {
            readonly Communication.ProtoServices.SimpleActions.SimpleActionsClient _client;
            AsynchronousActionDispatcher<bool, IServerResponse<System.UInt32>> Manager { get; }
            public ReturnThreadIDAction(Communication.ProtoServices.SimpleActions.SimpleActionsClient client)
            {
                _client = client;
                Manager = new(new()
                {ID = 13, CacheValidityPeriodSeconds = 0, ActionsStoreCapacity = 0, Name = "ReturnThreadID", CompareParameters = (param1, param2) => param1.Equals(param2), MainAction = async nothing =>
                {
                    var protoParam = new Empty();
                    return await _client.ReturnThreadIDAsync(protoParam, new Grpc.Core.Metadata{new Grpc.Core.Metadata.Entry("SessionKey", Account.SessionKey ?? "")});
                }});
            }
            /// <summary>
            /// Returns last result of invocation with same parameters if in cache and not expired. Otherwise invokes server action, puts it to cache and returns the result.
            /// </summary>
            public async Task<System.UInt32> GetResultAsync()
            {
                return await ClientCommonPipelines.InvokeServerAction<bool, System.UInt32>(() => Manager.InvokeAsync(false));
            }
            public void InvalidateAllCache()
            {
                Manager.InvalidateCache();
            }
        }
    }
}