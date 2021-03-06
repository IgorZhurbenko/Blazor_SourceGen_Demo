// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using Web.Server;
using System.Collections.Generic;
using Data;
using Business.ModelsComposition;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee;
using System.Threading.Tasks;
using Business.Selectors;
using Data.Entities.DataHolders;
using RandomDataGenerator.Randomizers;
using SourceGeneration.Attributes.Web.Server.Actions;
using Communication.Models.PaginationRequests.EmployeePaginationRequest;
using System.Diagnostics;

namespace Web.Server.StandardActions
{
    public static partial class EmployeeCustomActions
    {
        public static IEnumerable<IEmployeeReference> GetByName(ServerRequest<string> request)
        {
            var dbContext = new ApplicationDbContext();

            var employees = dbContext.Employees.Where(e => e.FirstName.ToLower() == request.Message.ToLower()).Select(e => e.ComposeReference());

            return employees;
        }
        
        public static async Task<IEnumerable<IEmployeeReference>> GetSameArrayAsync(ServerRequest<IList<IEmployeeReference>> references)
        {
            return await Task.Run(() => references.Message);
        }

        public static IEnumerable<IEmployeeReference> GetReferrables(ServerRequest<string> criteria)
        {
            var dbContext = new ApplicationDbContext();
            var refSelector = EmployeeSelectors.ReferenceSelector;
            
            var subresult = dbContext.Employees.Select(refSelector);

            string pattern = $"%{criteria.Message}%";

            var result = subresult.Where(r => EF.Functions.Like(r.Representation, pattern));
            return result;
        }
        
        public static bool CreateManyEmployees(ServerRequest<uint> numberToCreate)
        {
            uint number = numberToCreate.Message;
            if (numberToCreate.Message > 1000)
            {
                number = 1000;
            }
            var rlastname = new RandomizerLastName(new RandomDataGenerator.FieldOptions.FieldOptionsLastName
            {
                UseNullValues = false,
                ValueAsString = true
            });
            var rfirstname = new RandomizerFirstName(new RandomDataGenerator.FieldOptions.FieldOptionsFirstName
            {
                UseNullValues = false,
                ValueAsString = true,
                Male = true,
                Female = true
            });
            var lastName = rlastname.Generate();
            var emps = Enumerable.Range(1, (int)numberToCreate.Message)
                .Select(n => new Employee
                {
                    FirstName = rfirstname.Generate(),
                    LastName = rlastname.Generate(),
                }).ToList();

            var dbContext = new ApplicationDbContext();
            foreach (var e in emps)
            {
                e.BeforeSave();
            }

            dbContext.AddRange(emps);
            dbContext.SaveChanges();

            return true;
            
        }

    }
}