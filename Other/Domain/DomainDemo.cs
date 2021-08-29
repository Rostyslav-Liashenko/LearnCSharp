using System;
using System.Reflection;

namespace LearnDomain
{
    static class DomainDemo
    {
        static void Main()
        {
            AppDomain domain = AppDomain.CurrentDomain;
            Console.WriteLine($"Name: {domain.FriendlyName}");
            Console.WriteLine($"Base Directory: {domain.BaseDirectory}");
            Console.WriteLine();
            Assembly[] assemblies = domain.GetAssemblies();
            foreach (var asm in assemblies)
                Console.WriteLine(asm.GetName().Name);    
        }
    }
}
