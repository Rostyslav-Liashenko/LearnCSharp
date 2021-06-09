namespace LearnInterfaceProperties
{
    public interface ISeries
    {
        int Next
        {
            get;
            set;
        }

        int this[int index]
        {
            get;
        }
    }
}
