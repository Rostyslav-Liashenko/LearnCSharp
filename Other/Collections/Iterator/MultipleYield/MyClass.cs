using System.Collections;

namespace LearnCollections
{
    public class MyClass
    {
        public IEnumerator GetEnumerator()
        {
            yield return 'A';
            yield return 'B';
            yield return 'C';
            yield return 'D';
            yield return 'E';
        }
    }
}
