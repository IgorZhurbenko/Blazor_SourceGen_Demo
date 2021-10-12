using Common.Extensions.Object;
using System;
using System.Threading.Tasks;

namespace Common.Actions
{
    public class AsynchronousActionDispatcher<TPayload, TResult> : ActionDispatcher<TPayload, TResult>
    {
        public AsynchronousActionSettings<TPayload, TResult> Settings;

        public AsynchronousActionDispatcher(AsynchronousActionSettings<TPayload, TResult> settings): base(settings)
        {
            Settings = settings;
        }

        public async Task<TResult> InvokeAsync(TPayload payload)
        {
            if (GetResultFromCache(payload, out var result))
            {
                //Console.WriteLine($"Took result value for {Settings.Name} with payload {payload.ToJson()} from cache.");
                return result;
            }
            return await InvokeWithoutCacheCheckAsync(payload);
        }
        public async Task<TResult> InvokeWithoutCacheCheckAsync(TPayload payload)
        {
            TResult result = default(TResult);
            ActionStatus status = new ActionStatus
            {
                IsUnderway = true
            };
            try
            {
                var invocation = RecordInvocation(payload, result, status);
                
                result = await Settings.MainAction(payload);
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
