using Data.Entities.Documents;
using System.Collections.Generic;

namespace Data.Entities.Documents
{
    public partial class OutcomingOrder : Document
    {
        public ICollection<IncomingOrder> OrdersIncoming { get; set; }
    }
}