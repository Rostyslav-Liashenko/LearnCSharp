using System;
using System.Reflection;

namespace LearnReflection
{
    static class ReflectDemo
    {
        static void Main()
        {
            Type t = typeof(MyClass);
            Console.WriteLine("Analyze methods, define in class" + t.Name);
            Console.WriteLine();
            Console.WriteLine("Methods:");
            MethodInfo[] mi = t.GetMethods();
            foreach (MethodInfo m in mi)
            {
                Console.Write(" " + m.ReturnType.Name + " " + m.Name + "(");
                ParameterInfo[] pi = m.GetParameters();
                for (int i = 0; i < pi.Length; i++)
                {
                    Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);
                    if (i + 1 < pi.Length)
                        Console.Write(",");
                }
                Console.Write(")");
                Console.WriteLine();
            }
        }
    }
}
