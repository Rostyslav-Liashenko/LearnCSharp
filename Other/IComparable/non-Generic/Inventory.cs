using System;

namespace LearnCollections
{
    public class Inventory : IComparable
    {
        private string name;
        private double cost;
        private int onhand;

        public Inventory(string n, double c, int h)
        {
            name = n;
            cost = c;
            onhand = h;
        }

        public override string ToString()
        {
            return $"{name,-10}Cost:{cost,6:C} onhand: {onhand}";
        }

        public int CompareTo(object obj)
        {
            Inventory b = (Inventory) obj;
            return name.CompareTo(b.name);
        }
        
    }
}
