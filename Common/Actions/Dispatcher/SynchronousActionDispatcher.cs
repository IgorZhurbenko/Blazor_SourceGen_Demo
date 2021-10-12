using System;

namespace Common.Actions
{
    public class SynchronousActionDispatcher<TPayload, TResult> : ActionDispatcher<TPayload, TResult>
    {
        public SynchronousActionSettings<TPayload, TResult> Settings;

        public SynchronousActionDispatcher(SynchronousActionSettings<TPayload, TResult> settings) : base(settings)
        {
            Settings = settings;
        }

        public TResult Invoke(TPayload payload)
        {
            if (GetResultFromCache(payload, out var result))
            {
                return result;
            }

            return InvokeWithoutCacheCheck(payload);

        }

        public TResult InvokeWithoutCacheCheck(TPayload payload)
        {
            TResult result = default(TResult);
            ActionStatus status = new ActionStatus
            {
                IsUnderway = true
            };
            try
            {
                var invocation = RecordInvocation(payload, result, status);
                result = Settings.MainAction(payload);
                invocation.Result = result;
                status.IsUnderway = false;
                return result;
            }
            catch (Exception ex)
            {
                status.IsUnderway = false;
                status.Error = ex;
                throw;
            }
        }
    }

}
