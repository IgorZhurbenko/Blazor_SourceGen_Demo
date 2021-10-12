// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using System.Linq;
using System;
using System.Collections.Generic;
using Data;
using Data.Entities.DataHolders;
using Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee;
using System.Linq.Expressions;
namespace Business.Selectors
{
    public static partial class EmployeeSelectors
    {
        public static Expression<Func<Employee, IEmployeeModel>> ModelSelector(ApplicationDbContext dbContext) => e1 => new EmployeeModel{FirstName = e1.FirstName, LastName = e1.LastName, // Referring properties.
        Reference = dbContext.Employees.Where(e2 => e2 == e1).Select(EmployeeSelectors.ReferenceSelector).FirstOrDefault(), Mentor = dbContext.Employees.Where(e2 => e2 == e1.Mentor).Select(EmployeeSelectors.ReferenceSelector).FirstOrDefault() ?? new Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.EmployeeReference(), ResponsibleForGoods = e1.ResponsibleForGoods.AsQueryable().Select(GoodSelectors.ReferenceSelector).ToList(), };
    }
}