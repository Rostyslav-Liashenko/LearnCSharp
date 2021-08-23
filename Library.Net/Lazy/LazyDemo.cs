namespace LearnFeatures
{
    static class LazyDemo
    {
        static void Main()
        {
            Reader reader = new Reader();
            reader.ReadEbook();
            reader.ReadBook();
        }
    }
}
