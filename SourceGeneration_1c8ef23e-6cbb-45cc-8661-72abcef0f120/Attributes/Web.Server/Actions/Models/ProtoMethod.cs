using SourceGeneration.Auxiliary;
using System.Linq;

namespace SourceGeneration.Attributes.Web.Server.Actions.Models
{
    public class ProtoMethod
    {
        public string Name;
        public ProtoService Owner;
        public string ReturnedTypeSignature;
        public string ParameterSignature;
        public CommunicationMethod From;
        public bool DotnetTypeMustBeConvertedToProto;

        public string DeclarationString => $"rpc {Name} ({ParameterSignature}) returns ({ReturnedTypeSignature.Split('.').Last().MustNotEndWith(">")});";
    }
}
