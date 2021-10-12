using Common.Extensions;
using Common.Extensions.Object;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Common.Actions
{
    public abstract class ActionDispatcher<TPayload, TResult>
    {
        protected ActionDispatcher(ActionSettings<TPayload> settings)
        {
            _settings = settings;
        }

        public List<AccountedActionInvocation<TPayload, TResult>> Invocations { get; } = new();
        public IActionStatus Status => Invocations.LastOrDefault()?.Status ?? new ActionStatus();

        private readonly ActionSettings<TPayload> _settings;

        public bool GetResultFromCache(TPayload payload, out TResult result)
        {
            var lastInvocation = Invocations.LastOrDefault(i => !i.Expired && !i.Status.IsUnderway && _settings.CompareParameters(i.Payload, payload));

            if (lastInvocation == null)
            {
                result = default(TResult);
                return false;
            }
            else
            {
                result = lastInvocation.Result;
                return true;
            }
        }

        public void InvalidateCache(TPayload payload)
        {
            foreach (var invocation in Invocations.Where(i => _settings.CompareParameters(i.Payload, payload)))
            {
                invocation.Expired = true;
            }
        }

        public void InvalidateCache()
        {
            foreach (var invocation in Invocations)
            {
                invocation.Expired = true;
            }
        }

        protected AccountedActionInvocation<TPayload, TResult> RecordInvocation(TPayload payload, TResult result, ActionStatus status)
        {
            var invocation = new AccountedActionInvocation<TPayload, TResult> 
            {
                ActionID = _settings.ID,
                ExpiresAt = DateTime.UtcNow.AddSeconds((double)_settings.CacheValidityPeriodSeconds),
                InvocationTime = DateTime.UtcNow,
                Result = result,
                Payload = payload,
                Status = status
            };
            Invocations.Add(invocation);
            return invocation;
        }
    }


    public interface IActionStatus
    {
        public bool IsUnderway { get; }
        public Exception Error { get; }

        public bool Faulted => Error != null;
    }

    public class ActionStatus : IActionStatus
    {
        public bool IsUnderway { get; set; }
        public Exception Error { get; set; }
    }

}
