using System;
using System.Collections.Generic;

namespace LearnCollections
{
    class HashSetDemo
    {
        static void Show(string msg, HashSet<char> set)
        {
            Console.WriteLine(msg);
            Console.WriteLine(String.Join(" ", set));
        }
        
        static void Main()
        {
            HashSet<char> setA = new HashSet<char>();
            HashSet<char> setB = new HashSet<char>();

            setA.Add('A');
            setA.Add('B');
            setA.Add('C');

            setB.Add('C');
            setB.Add('D');
            setB.Add('E');
            Show("SetA: ", setA);
            Show("SetB: ", setB);
            setA.SymmetricExceptWith(setB);
            Show("setA after symmetricExceptWith(setB)", setA);
            setA.UnionWith(setB);
            Show("SetA after UnionWith(setB)", setA);
            setA.ExceptWith(setB);
            Show("setA after ExceptWith(setB)", setA);
        }
    }
}
