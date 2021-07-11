using System;
using System.Reflection;

namespace LearnReflection
{
    class AutomaiteDetectedType
    {
        static void Main()
        {
            int val;
            Assembly asm = Assembly.LoadFrom("MyClass.dll");
            Type[] allTypes = asm.GetTypes();
            Type t = allTypes[0];
            Console.WriteLine("Used: " + t.Name);
            ConstructorInfo[] ci = t.GetConstructors();
            ParameterInfo[] cpi = ci[0].GetParameters();
            object reflectOb;
            if (cpi.Length > 0)
            {
                object[] consArgs = new object[cpi.Length];
                for (int n = 0; n < cpi.Length; n++)
                    consArgs[n] = 10 + n * 20;
                reflectOb = ci[0].Invoke(consArgs);
            }
            else
                reflectOb = ci[0].Invoke(null);
            Console.WriteLine("\n Call methods for object");
            Console.WriteLine();
            MethodInfo[] mi = t.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
            foreach (MethodInfo m in mi)
            {
                Console.WriteLine("Call method {0}",m.Name);
                ParameterInfo[] pi = m.GetParameters();
                switch (pi.Length)
                {
                    case 0:
                        if (m.ReturnType == typeof(int))
                        {
                            val = (int) m.Invoke(reflectOb, null);
                            Console.WriteLine("Val = " + val);
                        }
                        else if (m.ReturnType == typeof(void))
                        {
                            m.Invoke(reflectOb, null);
                        }
                        break;
                    case 1:
                        if (pi[0].ParameterType == typeof(int))
                        {
                            object[] args = new object[1];
                            args[0] = 14;
                            if ((bool) m.Invoke(reflectOb,args))
                                Console.WriteLine("Value 14 between x and y");
                            else 
                                Console.WriteLine("Value 14 not between x and y");
                        }
                        break;
                    case 2:
                        if (pi[0].ParameterType == typeof(int) && pi[1].ParameterType == typeof(int))
                        {
                            object[] args = new object[2];
                            args[0] = 9;
                            args[1] = 18;
                            m.Invoke(reflectOb, args);
                        }
                        else if (pi[0].ParameterType == typeof(double) && pi[1].ParameterType == typeof(double))
                        {
                            object[] args = new object[2];
                            args[0] = 1.12;
                            args[1] = 23.4;
                            m.Invoke(reflectOb, args);
                        }
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
