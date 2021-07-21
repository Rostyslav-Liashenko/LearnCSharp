namespace LearnLINQ
{
    public class WorkerTask
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public WorkerTask(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}
