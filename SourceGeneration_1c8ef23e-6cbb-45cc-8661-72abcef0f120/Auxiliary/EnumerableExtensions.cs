using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SourceGeneration.Auxiliary
{
    public static class EnumerableExtensions
    {
        public static List<T> DistinctBy<T>(this IEnumerable<T> objects, Func<T, T, bool> equalityExpression)
        {
            var res = new List<T>();
            foreach (var obj in objects)
            {
                if (!res.Any(o => equalityExpression(obj, o)))
                {
                    res.Add(obj);
                }
            }
            return res;
        }

        public static List<TObject> DistinctBy<TObject, TValue>(this IEnumerable<TObject> objects, Func<TObject, TValue> equalityProp)
        {
            var res = new List<TObject>();
            foreach (var obj in objects)
            {
                if (!res.Any(o => equalityProp(obj).Equals(equalityProp(o))))
                {
                    res.Add(obj);
                }
            }
            return res;
        }
    }
}
