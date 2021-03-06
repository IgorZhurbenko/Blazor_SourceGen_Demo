// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using Communication.ProtoModels;
using System.Linq;
using System;
using System.Collections.Generic;
using Data;
using Data.Entities.Documents;
using Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder;
using System.Linq.Expressions;
namespace Business.Selectors
{
    public static partial class OutcomingOrderSelectors
    {
        public static readonly Expression<Func<OutcomingOrder, IOutcomingOrderReference>> ReferenceSelector = e1 => new Communication.Models.Entities.ReferrableEntities.Documents.OutcomingOrder.OutcomingOrderReference{ID = e1.ID, Representation = e1.Representation};
    }
}