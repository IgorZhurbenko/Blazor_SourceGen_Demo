using Business.ModelsComposition;
using Business.Selectors;
using Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee;
using Communication.Models.Filters.EmployeeModelFilter;
using Communication.Models.Filters.ReferenceFilter;
using Communication.Models.Filters.StringFilter;
using Communication.Models.PaginationRequests.EmployeePaginationRequest;
using Communication.ProtoModels.Conversion;
using Data;
using Data.Entities.DataHolders;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Web.Server.StandardActions;

namespace WholeTesting
{



    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {


        }

        static string GetRepresentation(Employee e) => e.FirstName + e.LastName;

        class EmployeeMetadata
        {
            public readonly static string Name = "Employee";
        }

        static Expression<Func<Employee, string>> RepresentationSelector1 = e => e.FirstName + " " + e.LastName;
        static readonly Expression<Func<Employee, string>> RepresentationSelector2 = e => $"{EmployeeMetadata.Name} Number {e.ID}";

        [Test]
        public void Test2()
        {
            var dbContext = new ApplicationDbContext();

            Expression<Func<Employee, IEmployeeReference>> employeeReferenceSelector = e => new EmployeeReference
            {
                ID = e.ID,
                Representation = e.GetReferenceRepresentation()
            };

            //IQueryable<IEmployeeModel> result2 = dbContext.Employees.Join(dbContext.Employees.Select(employeeReferenceSelector), e1 => e1.MentorID, e2 => e2.ID, (e1,e2) => new EmployeeModel
            //{
            //    FirstName = e1.FirstName,
            //    LastName = e1.LastName,
            //    Mentor = dbContext.Employees.Where(e3 => e3.),

            //});

            var result3 = dbContext.Employees.Select(e1 => new
            {
                FirstName = e1.FirstName,
                LastName = e1.LastName,
                MentorRepresentation = e1.MentorID == null ? null : dbContext.Employees.Where(e2 => e2.ID == e1.MentorID).Select(RepresentationSelector1)
                //.Select(r => new EmployeeReference
                //{ 
                //    ID = e1.MentorID.Value,
                //    Representation = r
                //})
                .FirstOrDefault()
                ,
                MentorID = e1.MentorID == null ? 0 : e1.MentorID.Value
            }
            ).Select(e1 => new EmployeeModel
            {
                FirstName = e1.FirstName,
                LastName = e1.LastName,
                Mentor = new EmployeeReference
                {
                    ID = e1.MentorID,
                    Representation = e1.MentorRepresentation
                }
            }).Where(e => e.Mentor.Representation.Contains("go"));
        }

        [Test]
        public void Test3()
        {
            var dbContext = new ApplicationDbContext();
            Func<ApplicationDbContext, Expression<Func<Employee, IEmployeeReference>>> CreateReferenceSelector = dbc => e => new EmployeeReference
            {
                Representation = dbc.Employees.Where(e2 => e2.ID == e.ID).Select(RepresentationSelector1).FirstOrDefault(),
                ID = e.ID
            };

            var result = dbContext.Employees.Select(CreateReferenceSelector(dbContext));
        }

        [Test]
        public void Test4()
        {
            var dbContext = new ApplicationDbContext();

            var selector = Business.Selectors.EmployeeSelectors.ModelSelector(dbContext);

            var result = dbContext.Employees.Select(selector);
        }

        [Test]
        public void Test5()
        {
            var result = EmployeeCustomActions.GetReferrables("go");
        }

        
        [Test]
        public void EmployeePagintaion()
        {
            var pagRequest = new EmployeePaginationRequestModel
            {
                PageNumber = 1,
                Filter = new EmployeeModelFilterModel
                {
                    Limit = 10,
                    Reference = new ReferenceFilterModel
                    {
                        Representation = new StringFilterModel
                        {
                            Pattern = "%a%"
                        }
                    }
                },

            };
            var result1 = EmployeeStandardActions.GetPage(pagRequest);

        }

        [Test]
        public void FiltersConversion()
        {
            var dbContext = new ApplicationDbContext();
            IEmployeeModelFilterModel filter = new Communication.Models.Filters.EmployeeModelFilter.EmployeeModelFilterModel()
            {
                //FirstName = new Communication.ProtoModels.StringFilterModel
                //{
                //    Pattern = "%l%"
                //},

                FirstName = null,
                LastName = null,
                Mentor = new Communication.Models.Filters.ReferenceFilter.ReferenceFilterModel
                {
                    In = new List<uint>()
                    {
                        0, 2, 1
                    }
                },
                Reference = new Communication.Models.Filters.ReferenceFilter.ReferenceFilterModel
                {
                    //In = new List<uint>()
                    //{
                    //    1,2,3
                    //},
                    //NotIn = new List<uint>()
                    //{
                    //    5,6,7,8,9,10
                    //}
                }

            };

            var expression = filter.ToExpression();

            int[] ids = { 1, 2, 3 };

            var result = dbContext.Employees.Select(EmployeeSelectors.ModelSelector(dbContext)).Where(e => ids.Contains((int)e.Mentor.ID));
        }

        [Test]
        public void CreateEmployees()
        { 
        }

        [Test]
        public void MentorFilter()
        {
            var dbContext = new ApplicationDbContext();
            string pattern = "%p%";
            Expression<Func<IEmployeeModel, bool>> filter = e => EF.Functions.Like(e.Mentor.Representation, pattern);

            var a = dbContext.Employees.Select(EmployeeSelectors.ModelSelector(dbContext)).Where(filter);
            var result = a.ToArray();
        }
    }
}