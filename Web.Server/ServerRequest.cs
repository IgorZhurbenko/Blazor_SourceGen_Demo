
using Communication;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Communication.ProtoServices;

namespace Web.Server
{
    [SourceGeneration.Attributes.Web.Server.Actions.ProcessServerRequest]
    public class ServerRequest
    {
        public ServerCallContext Context;
    }
    public class ServerRequest<T> : ServerRequest
    {
        public T Message;

        public ServerRequest()
        {
        }

        public ServerRequest(T message, ServerCallContext context = null)
        {
            Message = message;
            Context = context;
        }

        public static implicit operator T(ServerRequest<T> from)
        {
            return from.Message;
        }

        public static implicit operator ServerRequest<T>(T from)
        {
            return new ServerRequest<T>
            {
                Message = from
            };
        }
        
    }

}