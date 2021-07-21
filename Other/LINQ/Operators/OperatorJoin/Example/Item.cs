namespace LearnLINQ
{
    public class Item
    {
        public string Name { get; set; }
        public int ItemNumber { get; set; }

        public Item(string n, int inum)
        {
            Name = n;
            ItemNumber = inum;
        }
    }
}
