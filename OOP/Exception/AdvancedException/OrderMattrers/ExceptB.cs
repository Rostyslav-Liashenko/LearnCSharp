namespace LearnException
{
    public class ExceptB : ExceptA
    {
        public ExceptB(string str) : base(str)
        {}

        public override string ToString()
        {
            return Message;
        }
    }
}
