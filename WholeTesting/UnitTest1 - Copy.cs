using Communication.Models.Entities.ReferrableEntities.DataHolders.Good;
using Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee;
using Communication.ProtoModels.Conversion;
using Data;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Business.ModelsComposition;
using Communication.ProtoModels;
using Microsoft.EntityFrameworkCore;
using Web.Server.StandardActions;
using Web.Server.OpenActions;
using Data.Entities.DataHolders;
using Data.Entities;
using Data.Entities.Documents.Trade;
using Business.Selectors;
using System.Linq.Expressions;
using System.Threading;
namespace WholeTesting
{



    public class DbTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var filter = new EmployeeModelFilterModel
            {
                Limit = 10
            };

            var request = new EmployeePaginationRequestModel() { Filter = filter, PageNumber = 1 };

            var page1 = EmployeeStandardActions.Dispatchers.GetPage.GetResult(request);

            var page2 = EmployeeStandardActions.Dispatchers.GetPage.GetResult(request);

            var page3 = EmployeeStandardActions.Dispatchers.GetPage.GetResult(request);

        }

        [Test]
        public void ThreadSleep()
        {
            List<Action> actions = new List<Action>();
            for (var count = 0; count < 10; count++)
            {
                actions.Add(() => Console.WriteLine(count));
            }
            foreach (var action in actions)
            {
                action();
            }
        }

        [Test]
        public void Threads()
        {
            var threadNumbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var thread = threadNumbers.Select(n => new Thread(() => Console.WriteLine(Thread.CurrentThread.ManagedThreadId))).ToArray();
        }

    }
}