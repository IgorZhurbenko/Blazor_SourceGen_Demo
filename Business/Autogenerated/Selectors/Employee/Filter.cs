// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace Business.Selectors
{
    public static partial class EmployeeSelectors
    {
        public static Expression<Func<Data.Entities.DataHolders.Employee, bool>> ToExpression(this Communication.Models.Filters.EmployeeModelFilter.IEmployeeModelFilterModel filter)
        {
            bool filtersFirstName = filter.FirstName != null;
            bool filtersLastName = filter.LastName != null;
            bool filtersReference = filter.Reference != null;
            bool filtersReferenceIn = filter.Reference?.In.Any() == true;
            bool filtersReferenceNotIn = filter.Reference?.In.Any() == true;
            bool filtersReferenceRepresentation = !string.IsNullOrEmpty(filter.Reference?.Representation.Pattern);
            string referencePattern = filter.Reference?.Representation.Pattern ?? "";
            bool filtersMentor = filter.Mentor != null;
            bool filtersMentorIn = filter.Mentor?.In.Any() == true;
            bool filtersMentorNotIn = filter.Mentor?.In.Any() == true;
            bool filtersMentorRepresentation = !string.IsNullOrEmpty(filter.Mentor?.Representation.Pattern);
            string mentorPattern = filter.Mentor?.Representation.Pattern ?? "";
            bool filtersResponsibleForGoods = filter.ResponsibleForGoods != null;
            bool filtersResponsibleForGoodsAll = filter.ResponsibleForGoods?.All != null;
            bool filtersResponsibleForGoodsAllIn = filter.ResponsibleForGoods?.All?.In.Any() == true;
            bool filtersResponsibleForGoodsAllNotIn = filter.ResponsibleForGoods?.All?.In.Any() == true;
            bool filtersResponsibleForGoodsAllRepresentation = !string.IsNullOrEmpty(filter.ResponsibleForGoods?.All?.Representation.Pattern);
            string responsibleForGoodsAllPattern = filter.ResponsibleForGoods?.All?.Representation.Pattern ?? "";
            bool filtersResponsibleForGoodsAny = filter.ResponsibleForGoods?.Any != null;
            bool filtersResponsibleForGoodsAnyIn = filter.ResponsibleForGoods?.Any?.In.Any() == true;
            bool filtersResponsibleForGoodsAnyNotIn = filter.ResponsibleForGoods?.Any?.In.Any() == true;
            bool filtersResponsibleForGoodsAnyRepresentation = !string.IsNullOrEmpty(filter.ResponsibleForGoods?.Any?.Representation.Pattern);
            string responsibleForGoodsAnyPattern = filter.ResponsibleForGoods?.Any?.Representation.Pattern ?? "";
            if (!(filtersFirstName || filtersLastName || filtersReference || filtersMentor || filtersResponsibleForGoods))
            {
                return item => true;
            }
            return item => (!filtersFirstName || EF.Functions.Like(item.FirstName, filter.FirstName.Pattern)) && (!filtersLastName || EF.Functions.Like(item.LastName, filter.LastName.Pattern)) && (!filtersReference || (!filtersReferenceIn || filter.Reference.In.Contains((uint)item.ID)) && (!filtersReferenceNotIn || !filter.Reference.NotIn.Contains((uint)item.ID)) && (!filtersReferenceRepresentation || EF.Functions.Like(item.Representation, referencePattern))) && (!filtersMentor || (!filtersMentorIn || filter.Mentor.In.Contains(item.Mentor.ID)) && (!filtersMentorNotIn || !filter.Mentor.NotIn.Contains(item.Mentor.ID)) && (!filtersMentorRepresentation || EF.Functions.Like(item.Mentor.Representation, mentorPattern))) && (!filtersResponsibleForGoods || (!filtersResponsibleForGoodsAll || ((!filtersResponsibleForGoodsAllIn || item.ResponsibleForGoods.All(i => filter.ResponsibleForGoods.All.In.Contains(i.ID))) && (!filtersResponsibleForGoodsAllNotIn || item.ResponsibleForGoods.All(i => !filter.ResponsibleForGoods.All.In.Contains(i.ID))) && (!filtersResponsibleForGoodsAllRepresentation || item.ResponsibleForGoods.All(i => EF.Functions.Like(i.Representation, responsibleForGoodsAllPattern))))) && (!filtersResponsibleForGoodsAny || ((!filtersResponsibleForGoodsAnyIn || item.ResponsibleForGoods.Any(i => filter.ResponsibleForGoods.Any.In.Contains(i.ID))) && (!filtersResponsibleForGoodsAnyNotIn || item.ResponsibleForGoods.Any(i => !filter.ResponsibleForGoods.Any.In.Contains(i.ID))) && (!filtersResponsibleForGoodsAnyRepresentation || item.ResponsibleForGoods.Any(i => EF.Functions.Like(i.Representation, responsibleForGoodsAnyPattern))))));
        }
    }
}