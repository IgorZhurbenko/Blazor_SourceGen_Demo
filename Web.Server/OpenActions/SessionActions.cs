using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Selectors;
using Communication.Exceptions;
using Communication.Models.Entities.ReferrableEntities.DataHolders.Persons.Employee;
using Communication.Models.Entities.ReferrableEntities.DataHolders.User;
using Communication.Models.Filters.EmployeeModelFilter;
using Communication.Models.StartSessionRequest;
using Data;
using SourceGeneration.Attributes.Web.Server.Actions;
using Web.Server.Backend;
using System.Security.Cryptography;
using System.Text;
using Data.Extensions;
using Communication.Models.StartSessionResponse;
using Microsoft.EntityFrameworkCore;
using Web.Server.StandardActions;
using Communication.Models.Entities.Permissions;
using Communication.Models.VerifySessionRequest;
using Business.ModelsComposition;

namespace Web.Server.OpenActions
{
    [ProcessServerRequest]
    public static partial class SessionActions
    {
        private static HashAlgorithm _hashAlgorithm = HashAlgorithm.Create();

        [AllowUnauthorised]
        [DestructureParameterInClientInvocation]
        public static IStartSessionResponseModel StartSession(ServerRequest<IStartSessionRequestModel> request)
        {
            string login = request.Message.Login;
            string password = request.Message.Password;

            string passwordHash = password.Hash();

            var dbContext = new ApplicationDbContext();

            var user = dbContext.Users.AsNoTracking().Where(u=>u.LoginName.ToLower() == login.ToLower() && passwordHash == u.PasswordHash).Include(u=>u.Permissions).FirstOrDefault() 
                ?? throw new InvalidCredentialsHadledException();

            var startedSession = Session.GetSessionByUser(user.ID);
            var reference = user.ComposeReference();
            if (startedSession == null)
            {
                var newSession = Session.StartNew(reference);
                Session.RegisterCurrentThreadForSession(newSession.Key);
                startedSession = newSession;
 
            }
            return new StartSessionResponseModel
            {
                SessionKey = startedSession.Key,
                User = reference,
                Permissions = user.Permissions.ComposeModel()
            };
        }


        public static bool EndSession(ServerRequest<string> request)
        {
            Session.EndByKey(request.Message);
            return true;
        }

        [DestructureParameterInClientInvocation]
        public static IPermissionsModel VerifySession(IVerifySessionRequestModel verifySession)
        {
            string sessionKey = verifySession.SessionKey;
            uint userId = verifySession.SessionUserID;
            var session = Session.GetOpenSessionByKey(sessionKey);
            if (session == null || session.User.ID != userId)
            {
                throw new InvalidSessionKeyHandledException("Session key or user don't match any open session.");
            }
            var user = UserStandardActions.Dispatchers.Get.GetResult(session.User);
            
            return user.Permissions;
        }
    }
}