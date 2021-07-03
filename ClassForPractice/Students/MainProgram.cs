using System;

namespace ConsoleApp5.TestInheritance
{
    public static class MainProgram
    {
        public static void Main()
        {
            Student[] students = new Student[2];
            students[0] = new Student("Dima","Kononenko","PSK-18",3.45);
            students[1] = new Aspirant("Andrey", "Shkarupa", "PSK-18", 5.0);
            foreach (Student student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }
    }
}
