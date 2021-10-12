using System;
using SourceGeneration.Attributes.Web.Server.Actions;
using Web.Server.Backend;
using Communication.Models.ChangePasswordRequest;
using Web.Server.StandardActions;
using System.Diagnostics;
using Data;
using Data.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Data.Entities.DataHolders.AccountingUsers;
using Communication.Exceptions;
namespace Web.Server.OpenActions
{

    [ProcessServerRequest]
    public static partial class AccountActions
    {
        [DestructureParameterInClientInvocation]
        public static bool ChangePassword(IChangePasswordRequestModel passwords)
        {
            var dbContext = new ApplicationDbContext();
            var hash = passwords.OldPassword.Hash();
            var login = Session.GetCurrentSession().User.Representation;
            var user = dbContext.Users.FirstOrDefault(u => u.LoginName.ToLower() == login.ToLower() && hash == u.PasswordHash);

            if (user != null)
            {
                user.PasswordHash = passwords.NewPassword.Hash();
                dbContext.SaveChanges();
                return true;
            }
            else 
            {
                throw new InvalidCredentialsHadledException($"Password specified as current doesn't fit the current user.");
            }
        }
    }
}