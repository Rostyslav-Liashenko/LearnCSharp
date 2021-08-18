using System.Collections;

namespace LearnCollections
{
    public class CompInv : IComparer
    {
        public int Compare(object x, object y)
        {
            Inventory a = (Inventory) x;
            Inventory b = (Inventory) y;
            return string.Compare(a.Name, b.Name);
        }
    }
}
