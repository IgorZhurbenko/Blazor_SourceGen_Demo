using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee;
using Communication.Models.Filters.EmployeeModelFilter;
using SourceGeneration.Attributes.Web.Server.Actions;

namespace Web.Server.OpenActions
{
    [AllowUnauthorised]
    public static partial class SimpleActions
    {
        public static async Task<ICollection<IEmployeeModel>> GetOneEmployee(ServerRequest request)
        {
            return new List<IEmployeeModel>
            {
                new EmployeeModel
                {
                    FirstName = "Igor",
                    LastName = "Zhurbenko",
                    Reference = new EmployeeReference
                    {
                        ID = 007,
                        Representation = "Igor Zhurbenko"
                    },
                    Mentor = new EmployeeReference
                    {
                        ID = 001,
                        Representation = "Sanya Pes"
                    }
                }
            };
        }

        public static async Task<ICollection<IEmployeeModel>> GetSeveralEmployees(ServerRequest<System.UInt32> request)
        {
            return Enumerable.Range(1, 1 + (int)request.Message).Select(i =>
            
                new EmployeeModel
                {
                    FirstName = "Employee",
                    LastName = $"# {i}",
                    Mentor = new EmployeeReference
                    {
                        ID = (uint)i + 1,
                        Representation = $"Employee #{i + 1}"
                    },
                    Reference = new EmployeeReference
                    {
                        ID = (uint)i,
                        Representation = $"Employee #{i}"
                    }

                }).ToArray();
        }

        public static async Task<IEnumerable<IEmployeeModel>> GetSorted(ServerRequest<IEnumerable<IEmployeeModel>> request)
        {
            return request.Message.Reverse();
        }

        public static async Task<bool> IsEvenCollection(ServerRequest<ICollection<string>> request)
        {
            return request.Message.Count % 2 == 0;
        }
        
        public static async Task<bool> ThrowException(ServerRequest<string> exceptionMessage)
        {
            throw new Exception(exceptionMessage.Message);
        }
        
        //[DestructureParameterInClientInvocation]
        public static async Task<IEmployeeModelFilterModel> ReturnSameFilter(ServerRequest<IEmployeeModelFilterModel> incomingFilter)
        {
            return incomingFilter.Message;
        }

        public static uint ReturnThreadID(ServerRequest nothing)
        {
            Thread.Sleep(1000);
            return (uint)System.Threading.Thread.CurrentThread.ManagedThreadId;
        }
    }
}