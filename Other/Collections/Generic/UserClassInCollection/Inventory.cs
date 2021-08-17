namespace LearnCollections
{
    public class Inventory
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
    }
}
