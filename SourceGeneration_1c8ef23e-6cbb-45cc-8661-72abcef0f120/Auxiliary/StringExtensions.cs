using SourceGeneration.Procession.Semantics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;


namespace SourceGeneration.Auxiliary
{
    public static class StringExtensions
    {
        private static Span<string> Trimmed(this string[] strings)
        {
            var result = new List<string>();
            int j, i;
            for (j = strings.Length - 1; string.IsNullOrEmpty(strings[j]); j--) 
            {
            }
            for (i = 0; i < j && string.IsNullOrEmpty(strings[i]); i++)
            {
            }
            if (j > i)
            {
                return new Span<string>(strings, i, j - i - 1);
            }
            else { return new Span<string>(); } 

        }   
        public static string TrimCertain(this string stringToTrim, string seekedString)
        {
            if (!stringToTrim.EndsWith(seekedString))
            {
                return stringToTrim;
            }
            else
            {
                return stringToTrim.Split(seekedString.ToCharArray()).Trimmed().ToArray().Join(seekedString);
            }
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
            return firstLetter.ToString().ToUpper() + String.Concat(str.Skip(1));
        }

        public static string LowerFirstLetter(this string str)
        {
            var firstLetter = str.First();
            return firstLetter.ToString().ToLower() + String.Concat(str.Skip(1));
        }
    }
}
