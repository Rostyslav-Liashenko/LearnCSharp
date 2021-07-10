using System;
using System.Reflection;

namespace LearnReflection
{
    static class InvokeConsDemo
    {
        static void Main()
        {
            Type t = typeof(Rectangle);
            ConstructorInfo[] constructors = t.GetConstructors();
            int x;
            for (x = 0; x < constructors.Length; x++)
            {
                ParameterInfo[] pi = constructors[x].GetParameters();
                if (pi.Length == 2)
                    break;
            }

            if (x == constructors.Length)
            {
                Console.WriteLine("Constructor is not found");
                return;
            }
            else
            {
                Console.WriteLine("Construct is found");
            }

            object[] args = new object[2];
            args[0] = 5;
            args[1] = 2;
            object rectangle = constructors[x].Invoke(args);
            MethodInfo[] mi = t.GetMethods();
            foreach (MethodInfo m in mi)
            {
                if (m.Name.CompareTo("GetPerimeter") == 0)
                {
                    double retVal = (double) m.Invoke(rectangle,null);
                    Console.WriteLine("Perimeter, return value = " + retVal);
                }
                else if (m.Name.CompareTo("GetArea") == 0)
                {
                    double retValue = (double) m.Invoke(rectangle, null);
                    Console.WriteLine("Area, return value = "+ retValue);
                }
            }
        }
    }
}
