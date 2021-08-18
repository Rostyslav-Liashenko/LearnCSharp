using System.Collections;

namespace LearnCollections
{
    public class MyClass
    {
        private char ch = 'A';
        
        public IEnumerable MyItr(int end)
        {
            for (int i = 0; i < end; i++)
                yield return (char) (ch + i);
        }

        public IEnumerable MyItr(int begin, int end)
        {
            for (int i = begin; i < end; i++)
                yield return (char) (ch + i);
        }
    }
}
