using System;
using System.Reflection;

namespace LearnReflection
{
    class ReflectAssemblyDemo
    {
        static void Main()
        {
            int val;
            Assembly asm = Assembly.LoadFrom("MyClass.exe");
            Type[] allTypes = asm.GetTypes();
            foreach (Type temp in allTypes)
                Console.WriteLine("Founded: " + temp.Name);
            Console.WriteLine();
            Type t = allTypes[0];
            Console.WriteLine("Used: " + t.Name);
            ConstructorInfo[] ci = t.GetConstructors();
            Console.WriteLine("Access constructor:");
            foreach (ConstructorInfo c in ci)
            {
                Console.Write(" " + t.Name + "(");
                ParameterInfo[] pi = c.GetParameters();
                for (int i = 0; i < pi.Length; i++)
                {
                    Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);
                    if (i + 1 < pi.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }
            Console.WriteLine();
            int x;
            for (x = 0; x < ci.Length; x++)
            {
                ParameterInfo[] pi = ci[x].GetParameters();
                if (pi.Length == 2) break;
            }

            if (x == ci.Length)
            {
                Console.WriteLine("Needed constructor not found");
                return;
            }
            else 
                Console.WriteLine("Find constructor with 2 parameters");

            object[] consArgs = new object[2];
            consArgs[0] = 10;
            consArgs[1] = 20;
            object reflectOb = ci[x].Invoke(consArgs);
            Console.WriteLine("\n Call method for object reflectOb");
            Console.WriteLine();
            MethodInfo[] mi = t.GetMethods();
            foreach (MethodInfo m in mi)
            {
                ParameterInfo[] pi = m.GetParameters();
                if (m.Name.CompareTo("Set") == 0 && pi[0].ParameterType == typeof(int))
                {
                    object[] args = new object[2];
                    args[0] = 9;
                    args[1] = 18;
                    m.Invoke(reflectOb, args);
                }
                else if (m.Name.CompareTo("Set") == 0 && pi[0].ParameterType == typeof(double))
                {
                    object[] args = new object[2];
                    args[0] = 1.12;
                    args[1] = 23.14;
                    m.Invoke(reflectOb, args);
                }
                else if (m.Name.CompareTo("Sum") == 0)
                {
                    val = (int) m.Invoke(reflectOb, null);
                    Console.WriteLine("Summa = " + val);
                }
                else if (m.Name.CompareTo("IsBetween") == 0)
                {
                    object[] args = new object[1];
                    args[0] = 14;
                    if ((bool) m.Invoke(reflectOb, args))
                        Console.WriteLine("Value 14 between x and y");
                }
                else if (m.Name.CompareTo("Show") == 0)
                {
                    m.Invoke(reflectOb, null);
                }
            }
        }
    }
}
