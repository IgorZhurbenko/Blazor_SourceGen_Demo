using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;
using Communication.Exceptions;
using Communication.Models.Entities.ReferrableEntities.DataHolders.User;
using Communication.Models.Entities.Permissions;
using Common.Extensions.Object;
using System.Collections.Generic;
using System.Linq;

namespace Web.Client
{
    public static class Account
    {
        public delegate void AccountEvent();
        public static event AccountEvent SignedIn;
        public static event AccountEvent SignedOut;
        public static event AccountEvent PermissionsChanged;

        private readonly static Dictionary<object, Func<Task>> AsyncActionOnAuthorisation = new();

        static Account()
        {
            SignedIn += () => { };
            SignedOut += () => { };
        }

        const string SessionKeyStorageKey = "SessionKey";
        public static string SessionKey { get; private set; }

        const string CurrentUser = "CurrentUser";
        public static IUserReference User { get; private set; }
        public static IPermissionsModel Permissions { get; private set; } = new Communication.Models.Entities.Permissions.PermissionsModel();

        public static async Task<bool> LoadSessionFromStorageAsync()
        {
            var sessionKey = await ClientStorage.GetFromStorageAsync<string>(SessionKeyStorageKey);
            var user = await ClientStorage.GetFromStorageAsync<UserReference>(CurrentUser);
            if (sessionKey != null && user != null)
            {
                SessionKey = sessionKey;
                User = user;
                return true;
            }
            return false;
        }

        public static async Task SaveSessionToStorageAsync()
        {
            await ClientStorage.PushToStorageAsync(SessionKeyStorageKey, SessionKey);
            await ClientStorage.PushToStorageAsync(CurrentUser, User);
        }

        public static async Task RemoveSessionFromStorageAsync()
        {
            await ClientStorage.RemoveFromStorageAsync(SessionKeyStorageKey);
            await ClientStorage .RemoveFromStorageAsync(CurrentUser);
        }

        public static async Task AuthoriseSession(string sessionId, IUserReference user, IPermissionsModel permissions = null)
        {
            SessionKey = sessionId;
            Permissions = permissions;
            User = user;

            await SaveSessionToStorageAsync();
            SignedIn();
        }

        public static void SetPermissions(IPermissionsModel permissions)
        {
            //Console.WriteLine(permissions.ToJson());
            Permissions = permissions;
            PermissionsChanged();
        }

        public static void AnnulAuthorisation()
        {
            SessionKey = null;
            Permissions = null;
            User = null;

            SignedOut();
            RemoveSessionFromStorageAsync();
        }

        public static bool Authorised()
        {
            return SessionKey != null && User?.Empty == false;
        }
        public static void UseNavigationManager(NavigationManager navMan)
        {
            _navMan = navMan;
        }
        private static NavigationManager _navMan;
        public static void RedirectToLogin(string redirectToAfter = null)
        {

            string from = _navMan.ToBaseRelativePath(_navMan.Uri);
            if (from.ToLower().EndsWith("/login") && from.ToLower().StartsWith("/login/"))
            {
                return;
            }
            string to = $"login/{redirectToAfter ?? from ?? ""}";

            _navMan.NavigateTo(to);
        }
        public static T ProcessThroughUnathorized<T>(Func<T> func, bool checkOnClient = true)
        {
            if (checkOnClient && !Authorised())
            {
                RedirectToLogin();
                return default(T);
            }
            try
            {
                var result = func();
                return result;
            }
            catch (ServerSideException ssex)
            {
                if (ssex.InnerException is UnauthorisedHandledException)
                {
                    RedirectToLogin();
                    return default(T);
                }
                else
                {
                    throw;
                }
            }
        }

        public static async Task<T> ProcessThroughUnathorizedAsync<T>(Func<Task<T>> func, bool checkOnClient = true)
        {
            if (checkOnClient && !Authorised())
            {
                RedirectToLogin();
                return default(T);
            }
            try
            {
                var result = await func();
                return result;
            }
            catch (ServerSideException ssex)
            {
                if (ssex.InnerException is UnauthorisedHandledException)
                {
                    RedirectToLogin();
                    return default(T);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}