using System;

namespace ConsoleApp5.Reader
{
    public class MainProgram
    {
        public static void Main()
        {
            const int countReader = 3;
            Reader[] readers = new Reader[countReader];
            readers[0] = new Reader("Rostislav", 12345,"CS", 2002, 7, 27);
            readers[1] = new Reader("Jenny", 4567, "CS", 2003, 8, 23);
            readers[2] = new Reader("Andriy", 6789, "Marketing", 2003, 12, 12);
            Console.WriteLine("Info of readers");
            Console.WriteLine();
            foreach (Reader reader in readers)
                Console.WriteLine(reader);
            readers[0].TakeBook(3);
            readers[1].TakeBook("MyWorld","C# for beginners");
        }
    }
}
