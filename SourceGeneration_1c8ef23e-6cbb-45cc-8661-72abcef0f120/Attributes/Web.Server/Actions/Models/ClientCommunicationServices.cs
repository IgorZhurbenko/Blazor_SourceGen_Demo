using SourceGeneration.Attributes.Data.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SourceGeneration.Attributes.Web.Server.Actions.Models
{
    public class ClientCommunicationServices
    {
        public List<ClientCommunicationService> Items;
        public Derived<List<ClientCommunicationService>> AggregatorService;
    }

    public class ClientCommunicationService : Derived<ProtoClassImplementation>
    {
        public ProtoService ProtoService;
        public List<ProtoMethodInvocation> Methods;
    }
}
