using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Common.Extensions.Object;
using Common.Extensions.String;

namespace Web.Client
{
    public static class ClientStorage
    {
        private static IJSRuntime _js;
        private static List<object> _innerStore = new();
        public static void UseJSRuntime(IJSRuntime js)
        {
            _js = js;
        }
        public static async Task PushToStorageAsync(string key, object value)
        {
            await _js.InvokeVoidAsync("localStorage.setItem", key, value.ToJson());
        }
        public static async Task RemoveFromStorageAsync(string key)
        {
            await _js.InvokeVoidAsync("localStorage.removeItem", key);
        }

        public static async Task<T> GetFromStorageAsync<T>(string key)
        {
            string item = await _js.InvokeAsync<string>("localStorage.getItem", key);
            if (item == null)
            {
                return default(T);
            }
            return item.Deserialize<T>();
        }
    }
}