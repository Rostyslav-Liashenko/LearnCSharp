using System.Threading;

namespace LearnThreading
{
    public class SharedRes
    {
        public static int Count = 0;
        public static Mutex Mtx = new Mutex();
    }
}
