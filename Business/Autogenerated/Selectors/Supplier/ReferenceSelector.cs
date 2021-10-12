// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using Communication.ProtoModels;
using System.Linq;
using System;
using System.Collections.Generic;
using Data;
using Data.Entities.DataHolders.Actors;
using Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Supplier;
using System.Linq.Expressions;
namespace Business.Selectors
{
    public static partial class SupplierSelectors
    {
        public static readonly Expression<Func<Supplier, ISupplierReference>> ReferenceSelector = e1 => new Communication.Models.Entities.ReferrableEntities.DataHolders.Counterparties.Supplier.SupplierReference{ID = e1.ID, Representation = e1.Representation};
    }
}