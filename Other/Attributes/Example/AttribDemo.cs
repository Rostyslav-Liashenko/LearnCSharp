using System;

namespace LearAttribute
{
    class AttribDemo
    {
        static void Main(string[] args)
        {
            Type t = typeof(UseAttrib);
            Console.Write("Attributes in class " + t.Name + ": ");
            object[] atrribs = t.GetCustomAttributes(false);
            foreach (object o in atrribs)
            {
                Console.WriteLine(o);
            }
            Console.Write("Note: ");
            Type tRemAtt = typeof(RemarkAttribute);
            RemarkAttribute ra = (RemarkAttribute) Attribute.GetCustomAttribute(t, tRemAtt);
            Console.WriteLine(ra.Remark);
        }
    }
}
