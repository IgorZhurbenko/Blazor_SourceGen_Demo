using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Extensions.Object
{
    public static class ObjectExtensions
    {
        public static string ToJson(this object obj, bool indents = false)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj, indents ? Newtonsoft.Json.Formatting.Indented : Newtonsoft.Json.Formatting.None);
        }

        public static bool CompareConsideringNulls<T>(this T obj1, T obj2)
        {
            if (obj1 == null && obj2 == null)
            {
                return true;
            }
            if (obj1 == null || obj2 == null)
            {
                return false;
            }
            return obj1.Equals(obj2);
        }
    }
}
