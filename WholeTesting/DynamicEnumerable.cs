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
using Common.AdvancedDataStructures;
using System.Threading.Tasks;

namespace WholeTesting
{
    public class DynamicEnumerableTests
    {
        
        [Test]
        public void Test1()
        {
            List<int> numbers = Enumerable.Range(1, 515).ToList();
            const int ps = 20;
            var testable = new DynamicEnumerable<int>(i =>
            {
                var result = numbers.Skip((int)((i - 1) * ps)).Take(ps).ToArray();
                Console.WriteLine($"Loaded {result.Length} items.");
                return result;
            });

            var list = testable.ToList();

        }

        [Test]
        public void Test2()
        {
            List<int> numbers = Enumerable.Range(5, 5).ToList();
            const int ps = 2;
            var testable = new DynamicAsyncEnumerable<int>(async i =>
            {
                var result = numbers.Skip((int)((i - 1) * ps)).Take(ps).ToArray();
                await Task.Delay(1000);
                Console.WriteLine($"Loaded {result.Length} items.");
                return result;
            });

            List<int> resultList = new();

            var task = Task.Run(async () =>
            {
                await foreach (var item in testable)
                {
                    resultList.Add(item);
                }
            }
            );
            task.Wait();
        }
    }
}