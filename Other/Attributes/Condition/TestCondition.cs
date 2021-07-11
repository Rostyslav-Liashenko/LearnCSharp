#define TRIAL

using System;
using System.Diagnostics;
namespace LearAttribute
{
    class TestCondition
    {
        [Conditional("TRIAL")]
        private void Trial()
        {
            Console.WriteLine("Trial version not intended for distribution.");
        }
            
        [Conditional("REALESE")]
        private void Release()
        {
            Console.WriteLine("Work version");
        }
        
        static void Main(string[] args)
        {
            TestCondition t = new TestCondition();
            t.Trial();
            t.Release();
        }
    }
}
