using System.Collections;

namespace LearnCollections
{
    public class MyClass
    {
        private char ch = 'A';

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 26; i++)
            {
                if (i == 10)
                    yield break;
                yield return (char) (ch + i); 
            }
        }
    }
}
