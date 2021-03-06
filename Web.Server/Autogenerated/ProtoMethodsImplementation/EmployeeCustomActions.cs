// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using System;
using System.Linq;
using System.Collections.Generic;
using Communication.ProtoServices;
using Communication.ProtoModels;
using System.Threading.Tasks;
using Communication.ProtoModels.Conversion;
using Web.Server.Services;
using Google.Protobuf.WellKnownTypes;
using Common.Actions;
using Web.Server;
using Web.Server.Backend;
using Communication.Exceptions;
namespace Web.Server.StandardActions
{
    public class EmployeeCustomActionsImplementation : Communication.ProtoServices.EmployeeCustomActions.EmployeeCustomActionsBase
    {
        public override async System.Threading.Tasks.Task<Communication.ProtoModels.EmployeeReferenceListMessage> GetByName(Communication.ProtoModels.StringMessage request, Grpc.Core.ServerCallContext context)
        {
            string sessionKey = context.RequestHeaders.GetValue("sessionkey");
            var parameter = new ServerRequest<string>{Message = request.Message, Context = context};
            Func<ServerRequest<string>, Communication.ProtoModels.EmployeeReferenceListMessage> dispatcherAction = p =>
            {
                ServerRequestProcessionPipelines.VerifySession(sessionKey);
                return new(Web.Server.StandardActions.EmployeeCustomActions.Dispatchers.GetByName.GetResult(p).ToProto());
            };
            var result = Session.RunTrackingThreadAndSession(() => ServerRequestProcessionPipelines.ProcessThroughExceptions<Communication.ProtoModels.EmployeeReferenceListMessage, System.Collections.Generic.IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeReference>, ServerRequest<string>>(parameter, dispatcherAction, context, 0), sessionKey);
            return result;
        }
        public override async System.Threading.Tasks.Task<Communication.ProtoModels.EmployeeReferenceListMessage> GetSameArrayAsync(Communication.ProtoModels.EmployeeReferenceListMessage request, Grpc.Core.ServerCallContext context)
        {
            string sessionKey = context.RequestHeaders.GetValue("sessionkey");
            var parameter = new ServerRequest<System.Collections.Generic.IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeReference>>{Message = request.Message, Context = context};
            Func<ServerRequest<System.Collections.Generic.IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeReference>>, Task<Communication.ProtoModels.EmployeeReferenceListMessage>> dispatcherAction = async p =>
            {
                ServerRequestProcessionPipelines.VerifySession(sessionKey);
                return new((await Web.Server.StandardActions.EmployeeCustomActions.Dispatchers.GetSameArrayAsync.GetResult(p)).ToProto());
            };
            var result = await Session.RunTrackingThreadAndSession(async () => await ServerRequestProcessionPipelines.ProcessThroughExceptionsAsync<Communication.ProtoModels.EmployeeReferenceListMessage, System.Collections.Generic.IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeReference>, ServerRequest<System.Collections.Generic.IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeReference>>>(parameter, dispatcherAction, context, 0), sessionKey);
            return result;
        }
        public override async System.Threading.Tasks.Task<Communication.ProtoModels.EmployeeReferenceListMessage> GetReferrables(Communication.ProtoModels.StringMessage request, Grpc.Core.ServerCallContext context)
        {
            string sessionKey = context.RequestHeaders.GetValue("sessionkey");
            var parameter = new ServerRequest<string>{Message = request.Message, Context = context};
            Func<ServerRequest<string>, Communication.ProtoModels.EmployeeReferenceListMessage> dispatcherAction = p =>
            {
                ServerRequestProcessionPipelines.VerifySession(sessionKey);
                return new(Web.Server.StandardActions.EmployeeCustomActions.Dispatchers.GetReferrables.GetResult(p).ToProto());
            };
            var result = Session.RunTrackingThreadAndSession(() => ServerRequestProcessionPipelines.ProcessThroughExceptions<Communication.ProtoModels.EmployeeReferenceListMessage, System.Collections.Generic.IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeReference>, ServerRequest<string>>(parameter, dispatcherAction, context, 0), sessionKey);
            return result;
        }
        public override async System.Threading.Tasks.Task<Communication.ProtoModels.BooleanMessage> CreateManyEmployees(Communication.ProtoModels.UInt32Message request, Grpc.Core.ServerCallContext context)
        {
            string sessionKey = context.RequestHeaders.GetValue("sessionkey");
            var parameter = new ServerRequest<uint>{Message = request.Message, Context = context};
            Func<ServerRequest<uint>, Communication.ProtoModels.BooleanMessage> dispatcherAction = p =>
            {
                ServerRequestProcessionPipelines.VerifySession(sessionKey);
                return new(Web.Server.StandardActions.EmployeeCustomActions.Dispatchers.CreateManyEmployees.GetResult(p).ToProto());
            };
            var result = Session.RunTrackingThreadAndSession(() => ServerRequestProcessionPipelines.ProcessThroughExceptions<Communication.ProtoModels.BooleanMessage, System.Boolean, ServerRequest<uint>>(parameter, dispatcherAction, context, 0), sessionKey);
            return result;
        }
    }
}