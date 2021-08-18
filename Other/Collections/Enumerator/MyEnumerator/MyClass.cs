using System.Collections;

namespace LearnCollections
{
    public class MyClass : IEnumerator, IEnumerable
    {
        private char[] chrs = {'A', 'B', 'C', 'D'};
        private int idx = -1;

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public object Current
        {
            get
            {
                return chrs[idx];
            }
        }

        public bool MoveNext()
        {
            if (idx == chrs.Length - 1)
            {
                Reset();
                return false;
            }

            idx++;
            return true;
        }

        public void Reset()
        {
            idx = -1;
        }
    }
}
