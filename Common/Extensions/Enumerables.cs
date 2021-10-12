using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Extensions.Enumerables
{
    public static class Enumerables
    {
        /// <summary>
        /// Removes elements from collection by predicate and returns reference for the same collection.
        /// </summary>
        /// <typeparam name="TCollection"></typeparam>
        /// <typeparam name="TItem"></typeparam>
        /// <param name="collection"></param>
        /// <param name="clauseForDeletion"></param>
        /// <returns></returns>
        public static ICollection<TItem> RemoveWhere<TItem>(this ICollection<TItem> collection, Func<TItem, bool> clauseForDeletion)
        {
            foreach (var item in collection)
            {
                if (clauseForDeletion(item))
                {
                    collection.Remove(item);
                }
            }
            return collection;
        }
    }
}
