namespace ConsoleApp6.TestClassObject
{
    public class MyClass
    {
        public static int count = 0;

        private int id;

        public MyClass()
        {
            id = count;
            count++;
        }

        public override string ToString()
        {
            return "object #" + id + " class MyClass";
        }
    }
}
