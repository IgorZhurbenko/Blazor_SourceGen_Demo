// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace Business.Selectors
{
    public static partial class IncomingOrderSelectors
    {
        public static Expression<Func<Data.Entities.IncomingOrder, bool>> ToExpression(this Communication.Models.Filters.IncomingOrderModelFilter.IIncomingOrderModelFilterModel filter)
        {
            bool filtersNumber = filter.Number != null;
            bool filtersReference = filter.Reference != null;
            bool filtersReferenceIn = filter.Reference?.In.Any() == true;
            bool filtersReferenceNotIn = filter.Reference?.In.Any() == true;
            bool filtersReferenceRepresentation = !string.IsNullOrEmpty(filter.Reference?.Representation.Pattern);
            string referencePattern = filter.Reference?.Representation.Pattern ?? "";
            bool filtersRequestedGoods = filter.RequestedGoods != null;
            if (!(filtersNumber || filtersReference || filtersRequestedGoods))
            {
                return item => true;
            }
            return item => (!filtersNumber || EF.Functions.Like(item.Number, filter.Number.Pattern)) && (!filtersReference || (!filtersReferenceIn || filter.Reference.In.Contains((uint)item.ID)) && (!filtersReferenceNotIn || !filter.Reference.NotIn.Contains((uint)item.ID)) && (!filtersReferenceRepresentation || EF.Functions.Like(item.Representation, referencePattern)));
        }
    }
}