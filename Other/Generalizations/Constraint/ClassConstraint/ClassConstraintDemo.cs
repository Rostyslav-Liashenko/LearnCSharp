namespace LearnGeneralization
{
    class ClassConstrainteDemo
    {
        static void Main()
        {
            Test<MyClass> x = new Test<MyClass>();
            //Test<int> y = new Test<int>(); Error
        }
    }
}
