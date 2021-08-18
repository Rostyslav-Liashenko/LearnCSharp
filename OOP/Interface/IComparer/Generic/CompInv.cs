using System;
using System.Collections.Generic;

namespace LearnCollections
{
    public class CompInv<T> : IComparer<T> where T :Inventory
    {
        public int Compare(T x, T y)
        {
            return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
        }
    }
}
