using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Client.Components.Universal.Filters
{
    public class LeftRightValuePair<T> where T : IComparable<T>
    {
        public T Left;
        public T Right;

        public bool RightLessThanLeft => Left.CompareTo(Right) > 0;
    }
}
