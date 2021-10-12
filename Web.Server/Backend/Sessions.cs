using Communication.Exceptions;
using Communication.Models.Entities.ReferrableEntities.DataHolders.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Web.Server.Backend
{
    public class Session
    {
        private static ICollection<Session> OpenSessions = new List<Session>();


        public string Key;
        public ICollection<int> ThreadsInProcess;
        public IUserReference User;
        public DateTime LastTimeActive;

        public static Session StartNew(IUserReference user)
        {
            var result = new Session
            {
                User = user,
                Key = Guid.NewGuid().ToString(),
                LastTimeActive = DateTime.UtcNow,
                ThreadsInProcess = new List<int>()
            };
            OpenSessions.Add(result);
            return result;
        }

        public static void RegisterCurrentThreadForSession(string sessionKey)
        {
            var session = GetOpenSessionByKey(sessionKey) ?? throw new InvalidSessionKeyHandledException($"No open session with key {sessionKey}.");
            session.ThreadsInProcess.Add(Thread.CurrentThread.ManagedThreadId);
        }

        public static Session GetSessionByUser(uint userId)
        {
            return OpenSessions.FirstOrDefault(s => s.User.ID == userId);
        }

        public static Session GetOpenSessionByKey(string key)
        {
            return OpenSessions.FirstOrDefault(s => s.Key == key);
        }

        public static Session GetCurrentSession()
        {
            return OpenSessions.FirstOrDefault(s => s.ThreadsInProcess.Contains(Thread.CurrentThread.ManagedThreadId));
        }

        public static bool EndByKey(string key)
        {
            return OpenSessions.Remove(GetOpenSessionByKey(key));
        }

        public bool End()
        {
            return OpenSessions.Remove(this);
        }

        public static void RegisterActionForCurrentSection(uint actionId, object data = null)
        {

        }

        private Session()
        {
        }

        private static int RegisterOpenedThread(string sessionKey)
        {
            var os = OpenSessions.FirstOrDefault(s => s.Key == sessionKey);
            if (os != null)
            {
                var id = Thread.CurrentThread.ManagedThreadId;
                os.ThreadsInProcess.Add(id);
                return id;
            }
            return 0;
        }

        private static bool FinishThreadForSession(string sessionKey, int threadId)
        {
            var os = OpenSessions.FirstOrDefault(s => s.Key == sessionKey);
            if (os != null && os.ThreadsInProcess.Remove(threadId))
            {
                return true;
            }
            return false;
        }

        public static T RunTrackingThreadAndSession<T>(Func<T> function, string sessionKey)
        {
            var threadId = RegisterOpenedThread(sessionKey);
            var result = function();
            FinishThreadForSession(sessionKey, threadId);
            return result;
        }

        public static async Task<T> RunTrackingThreadAndSession<T>(Func<Task<T>> function, string sessionKey)
        {
            var threadId = RegisterOpenedThread(sessionKey);
            var result = await function();
            FinishThreadForSession(sessionKey, threadId);
            return result;
        }

        public override bool Equals(object obj)
        {
            return Key != null && obj is Session s && Key == s.Key;
        }
    }
}
