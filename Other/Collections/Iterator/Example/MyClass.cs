using System.Collections;

namespace LearnCollections
{
    public class MyClass
    {
        private char[] chrs = {'A', 'B', 'C', 'D'};

        public IEnumerator GetEnumerator()
        {
            foreach (char ch in chrs)
                yield return ch;
        }
    }
}
