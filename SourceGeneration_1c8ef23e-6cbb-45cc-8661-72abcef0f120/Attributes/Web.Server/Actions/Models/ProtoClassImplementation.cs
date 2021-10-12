using SourceGeneration.Attributes.Data.Entity.Models;
using System.Collections.Generic;

namespace SourceGeneration.Attributes.Web.Server.Actions.Models
{
    public class ProtoClassImplementation : Derived<ProtoService>
    {
        public ProtoService ProtoService;
        public List<ProtoMethodImplementation> MethodOverrides;
    }
}
