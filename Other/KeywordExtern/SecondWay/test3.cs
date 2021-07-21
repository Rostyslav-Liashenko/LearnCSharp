extern alias Asm1;
extern alias Asm2;

using System;

namespace LearnPartical
{
    class Demo
    {
        static void Main()
        {
            Asm1::MyNS.MyClass t = new Asm1::MyNS.MyClass();
            Asm2::MyNS.MyClass t2 = new Asm1::MyNS.MyClass();
        }
    }
}
