
using SourceGeneration.Procession.Semantics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;


namespace SourceGeneration.Auxiliary
{
    public static class DictionaryExtensions
    {
        public static TValue GetOrSet<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue valueToSet)
        {
            if (!dict.ContainsKey(key))
            {
                dict.Add(key, valueToSet);
                return valueToSet;
            }
            return dict[key];
        }
    }

}
