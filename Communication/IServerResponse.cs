// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using System;
using System.Linq;
using Communication.ProtoModels;
namespace Communication
{
    public interface IServerResponse
    {
        public Status Status { get; set; }
    }
    public interface IServerResponse<TMessage> : IServerResponse
    {
        public TMessage Message { get; }
    }
}