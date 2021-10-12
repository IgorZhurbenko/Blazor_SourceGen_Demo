using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Extensions.String
{
    public static class StringExtensions
    {
        public static string Join(this IEnumerable<string> strings, string joiner)
        {
            return string.Join(joiner, strings);
        }

        public static string MustNotEndWith(this string inputString, string unwantedEnding)
        {
            if (!inputString.EndsWith(unwantedEnding))
            {
                return inputString;
            }

            return MustNotEndWith(new string(inputString.Take(inputString.Length - unwantedEnding.Length).ToArray()), unwantedEnding);
        }

        public static string MustNotStartWith(this string inputString, string unwantedBeginning)
        {
            if (!inputString.StartsWith(unwantedBeginning))
            {
                return inputString;
            }

            return MustNotStartWith(new string(inputString.Skip(unwantedBeginning.Length).ToArray()), unwantedBeginning);
        }

        public static string MustEndWith(this string input, string desiredEnding)
        {
            if (input.EndsWith(desiredEnding))
            {
                return input;
            }

            return input + desiredEnding;
        }

        public static string MustStartWith(this string input, string desiredBeginning)
        {
            if (input.StartsWith(desiredBeginning))
            {
                return input;
            }

            return desiredBeginning + input;
        }

        public static string Capitalize(this string str)
        {
            var firstLetter = str.First();
            return firstLetter.ToString().ToUpper() + string.Concat(str.Skip(1));
        }

        public static string LowerFirstLetter(this string str)
        {
            var firstLetter = str.First();
            return firstLetter.ToString().ToLower() + string.Concat(str.Skip(1));
        }

        /// <summary>
        /// From json.
        /// </summary>
        /// <returns></returns>
        public static T Deserialize<T>(this string from)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(from);
            }
            catch (Exception)
            {
                return default;
            }
        }

        public static string JsonForUser(this string json)
        {
            return json.Replace("\"", "").Replace("{","").Replace("}", "");
        }

        public static bool IsVoid(this string source)
        {
            return string.IsNullOrEmpty(source);
        }

        public static string SurroundWithPercents(this string input)
        {
            return $"%{input}%";
        }
    }
}
