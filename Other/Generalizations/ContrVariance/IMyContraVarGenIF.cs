namespace LearnGeneralization
{
    public interface IMyContraVarGenIF<in T>
    {
        void Show(T obj);
    }
}