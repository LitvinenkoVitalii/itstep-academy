using System;
using System.Collections.Generic;

namespace Dictionary
{
    public class BaseComparer<T> : IComparer<T> where T : IComparable<T>
    {
        public int Compare(T x, T y)
        {
            return x.CompareTo(y);
        }
    }
}

