using Data.Entities.Documents.Trade;
using System.Collections.Generic;

namespace Data.Entities
{
    public partial class IncomingOrder : Documents.Document
    {
        public ICollection<IncomingOrderLine> RequestedGoods { get; set; }
    }

}