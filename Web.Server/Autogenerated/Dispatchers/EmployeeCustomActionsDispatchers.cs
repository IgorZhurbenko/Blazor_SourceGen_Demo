// Autogenerated. Will be overwritten on build. Remove this comment to cancel overwriting.

using System;
using System.Linq;
namespace Web.Server.StandardActions
{
    public static partial class EmployeeCustomActions
    {
        public static class Dispatchers
        {
            public static class GetByName
            {
                static Common.Actions.SynchronousActionDispatcher<Web.Server.ServerRequest<string>, System.Collections.Generic.IEnumerable<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeReference>> GetByNameDispatcher { get; } = new(new()
                {ID = 1, Name = "GetByName", CompareParameters = (p1, p2) => p1.Message.Equals(p2.Message), MainAction = p => Web.Server.StandardActions.EmployeeCustomActions.GetByName(p)});
                [SourceGeneration.Attributes.Web.Server.Actions.NotOpen]
                public static System.Collections.Generic.IEnumerable<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeReference> GetResult(Web.Server.ServerRequest<string> request) => GetByNameDispatcher.Invoke(request);
                [SourceGeneration.Attributes.Web.Server.Actions.NotOpen]
                public static void InvalidateCache(string request) => GetByNameDispatcher.InvalidateCache(new(request));
                [SourceGeneration.Attributes.Web.Server.Actions.NotOpen]
                public static void InvalidateCache()
                {
                    GetByNameDispatcher.InvalidateCache();
                }
            }
            public static class GetSameArrayAsync
            {
                static Common.Actions.AsynchronousActionDispatcher<Web.Server.ServerRequest<System.Collections.Generic.IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeReference>>, System.Collections.Generic.IEnumerable<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeReference>> GetSameArrayAsyncDispatcher { get; } = new(new()
                {ID = 2, Name = "GetSameArrayAsync", CompareParameters = (p1, p2) => p1.Message.Count() == p2.Message.Count() && p1.Message.All(i => p2.Message.Contains(i)), MainAction = async p => await Web.Server.StandardActions.EmployeeCustomActions.GetSameArrayAsync(p)});
                [SourceGeneration.Attributes.Web.Server.Actions.NotOpen]
                public static async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeReference>> GetResult(Web.Server.ServerRequest<System.Collections.Generic.IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeReference>> references) => await GetSameArrayAsyncDispatcher.InvokeAsync(references);
                [SourceGeneration.Attributes.Web.Server.Actions.NotOpen]
                public static void InvalidateCache(System.Collections.Generic.IList<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeReference> references) => GetSameArrayAsyncDispatcher.InvalidateCache(new(references));
                [SourceGeneration.Attributes.Web.Server.Actions.NotOpen]
                public static void InvalidateCache()
                {
                    GetSameArrayAsyncDispatcher.InvalidateCache();
                }
            }
            public static class GetReferrables
            {
                static Common.Actions.SynchronousActionDispatcher<Web.Server.ServerRequest<string>, System.Collections.Generic.IEnumerable<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeReference>> GetReferrablesDispatcher { get; } = new(new()
                {ID = 3, Name = "GetReferrables", CompareParameters = (p1, p2) => p1.Message.Equals(p2.Message), MainAction = p => Web.Server.StandardActions.EmployeeCustomActions.GetReferrables(p)});
                [SourceGeneration.Attributes.Web.Server.Actions.NotOpen]
                public static System.Collections.Generic.IEnumerable<Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee.IEmployeeReference> GetResult(Web.Server.ServerRequest<string> criteria) => GetReferrablesDispatcher.Invoke(criteria);
                [SourceGeneration.Attributes.Web.Server.Actions.NotOpen]
                public static void InvalidateCache(string criteria) => GetReferrablesDispatcher.InvalidateCache(new(criteria));
                [SourceGeneration.Attributes.Web.Server.Actions.NotOpen]
                public static void InvalidateCache()
                {
                    GetReferrablesDispatcher.InvalidateCache();
                }
            }
            public static class CreateManyEmployees
            {
                static Common.Actions.SynchronousActionDispatcher<Web.Server.ServerRequest<uint>, bool> CreateManyEmployeesDispatcher { get; } = new(new()
                {ID = 4, Name = "CreateManyEmployees", CompareParameters = (p1, p2) => p1.Message.Equals(p2.Message), MainAction = p => Web.Server.StandardActions.EmployeeCustomActions.CreateManyEmployees(p)});
                [SourceGeneration.Attributes.Web.Server.Actions.NotOpen]
                public static bool GetResult(Web.Server.ServerRequest<uint> numberToCreate) => CreateManyEmployeesDispatcher.Invoke(numberToCreate);
                [SourceGeneration.Attributes.Web.Server.Actions.NotOpen]
                public static void InvalidateCache(uint numberToCreate) => CreateManyEmployeesDispatcher.InvalidateCache(new(numberToCreate));
                [SourceGeneration.Attributes.Web.Server.Actions.NotOpen]
                public static void InvalidateCache()
                {
                    CreateManyEmployeesDispatcher.InvalidateCache();
                }
            }
        }
    }
}