namespace LearnGeneralization
{
    public class XY<T> where T : struct
    {
        public XY(T x, T y)
        {
            X = x;
            Y = y;
        }
        public T X { get; set; }
        public T Y { get; set; }
    }
}
