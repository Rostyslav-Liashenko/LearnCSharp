using System;
using System.Reflection;

namespace LearnReflection
{
    static class InvokeMethDemo
    {
        static void Main()
        {
            int val = 0;
            Type t = typeof(MyClass);
            MyClass reflectOb = new MyClass(10, 20);
            Console.WriteLine("Call methods, defines in class " + t.Name);
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
                    args[1] = 23.4;
                    m.Invoke(reflectOb, args);
                }
                else if (m.Name.CompareTo("Sum") == 0)
                {
                    val = (int) m.Invoke(reflectOb, null);
                    Console.WriteLine("Sum = " + val);
                }
                else if (m.Name.CompareTo("IsBetween") == 0)
                {
                    object[] args = new object[1];
                    args[0] = 14;
                    if ((bool) m.Invoke(reflectOb, args))
                    {
                        Console.WriteLine("Value 14 between x and y");
                    }
                    
                }
                else if (m.Name.CompareTo("Show") == 0)
                {
                    m.Invoke(reflectOb, null);
                }
            }
        }
    }
}
