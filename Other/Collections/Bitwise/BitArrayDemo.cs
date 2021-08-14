using System;
using System.Collections;

namespace LearnCollections
{
    class BitArrayDemo
    {
        private static void ShowBits(string rem, BitArray bits)
        {
            Console.WriteLine(rem);
            for (int i = 0; i < bits.Count; i++)
                Console.Write("{0, -6} ", bits[i]);
            Console.WriteLine();
        }
        
        static void Main()
        {
            BitArray ba = new BitArray(8);
            byte[] b = {67};
            BitArray ba2 = new BitArray(b);
            ShowBits("Content collection ba: ", ba);
            ba = ba.Not();
            ShowBits("Content collection ba after logical operation NOT:", ba);
            ShowBits("Content collection ba2: ", ba2);
            BitArray ba3 = ba.Xor(ba2);
            ShowBits("Result logical operation ba XOR ba2:", ba3);
        }
    }
}
