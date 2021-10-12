using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Client.Functions
{
    public class ItemsDynamicLoader<TItem>
    {

        private readonly uint _portionSize;
        private readonly Func<Task<IEnumerable<TItem>>> _pageLoadingFunctionAsync;

        public ItemsDynamicLoader(uint portionSize, Func<Task<IEnumerable<TItem>>> loadingFunctionAsync)
        {
            _portionSize = portionSize;
            _pageLoadingFunctionAsync = loadingFunctionAsync;
        }

        public async Task<List<TItem>> LoadForVirtualization<TItem>(int startIndex, int count)
        {
            throw new NotImplementedException();
        }
    }

    public static class DynamicLoading
    {
        public static async Task<List<TItem>> LoadForVirtualization<TItem>(int startIndex, int count, uint pageSize, Func<uint, Task<IList<TItem>>> loadingFunction)
        {
            var pagesNecessary = (uint)(count / pageSize) + (count % pageSize == 0 ? 0 : 1) + 1;
            var result = new List<TItem>();
            uint startPageNumber = (uint)(startIndex / pageSize + 0.5) + 1;
            var offset = startIndex % pageSize;
            for (uint p = 0; p < pagesNecessary; p++)
            {
                var pageNumberForTask = p;

                var emps = await loadingFunction(startPageNumber + pageNumberForTask);

                if (p == 0)
                {
                    result.AddRange(emps.Skip((int)offset));
                }
                else
                {
                    result.AddRange(emps);
                }
                if (emps.Count < pageSize)
                {
                    break;
                }
            }
            return result;
        }
    }
}
