namespace LearnLINQ
{
    public class InStockStatus
    {
        public int ItemNumber { get; set; }
        public bool InStock { get; set; }

        public InStockStatus(int n, bool b)
        {
            ItemNumber = n;
            InStock = b;
        }
    }
}
