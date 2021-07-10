using System;
using System.Reflection;

namespace LearnReflection
{
    static class InvokeMethDemo
    {
        static void Main()
        {
            Type t = typeof(Rectangle);
            Rectangle rectangle = new Rectangle(5, 2);
            MethodInfo[] mi = t.GetMethods();
            foreach (MethodInfo m in mi)
            {
                if (m.Name.CompareTo("GetPerimeter") == 0)
                {
                    double retVal = (double) m.Invoke(rectangle,null);
                    Console.WriteLine("Perimeter, return value = " + retVal);
                }

                if (m.Name.CompareTo("GetArea") == 0)
                {
                    double retValue = (double) m.Invoke(rectangle, null);
                    Console.WriteLine("Area, return value = "+ retValue);
                }
            }
        }
    }
}
