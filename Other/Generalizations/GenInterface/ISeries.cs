namespace LearnGeneralization
{
    public interface ISeries<T>
    {
        T GetNext();
        void Reset();
        void SetStart(T v);
    }
}
