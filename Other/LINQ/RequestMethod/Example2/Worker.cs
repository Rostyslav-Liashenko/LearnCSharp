namespace LearnLINQ
{
    public class Worker
    {
        public int Id { get; private set; }
        public string Name { get;  private set; }
        public double Rating { get; set; }

        public Worker(int id, string n, double r)
        {
            Id = id;
            Name = n;
            Rating = r;
        }
    }
}
