using System;

namespace Common.Actions
{
    public class AccountedActionInvocation<TParameter, TResult>
    {
        public ushort ActionID;
        public DateTime InvocationTime;
        public TParameter Payload;
        public DateTime ExpiresAt;
        public bool Expired { get { return DateTime.UtcNow >= ExpiresAt; } set { if (value) { ExpiresAt = default(DateTime); } } }
        public TResult Result;
        public ActionStatus Status;
    }
}
