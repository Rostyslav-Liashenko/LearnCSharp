namespace LearnCollections
{
    public class Inventory
    {
        public string Name { get; set; }
        private double cost;
        private int onhand;

        public Inventory(string n, double c, int h)
        {
            Name = n;
            cost = c;
            onhand = h;
        }

        public override string ToString()
        {
            return $"{Name,-10}Cost:{cost,6:C} onhand: {onhand}";
        }
    }
}
