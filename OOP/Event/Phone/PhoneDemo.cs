using System;
namespace LearnEventPractice
{
    class PhoneDemo
    {
        static void Main()
        {
            Phone somePhone = new Phone("0677670078");
            somePhone.Call += (sender, args) => Console.WriteLine("Call " + args.Message);
            somePhone.OnCall("Petro");
            somePhone.Charge += (sender, args) => Console.WriteLine("Phone is charge");
            somePhone.Discharge += (sender, args) => Console.WriteLine("Phone is discharge");
            somePhone.OnCharge();
            somePhone.OnDischarge();
        }
    }
}
