using System;
using ConsoleApp5.ComplexClass.Details;
using ConsoleApp5.ComplexClass.Professions;

namespace ConsoleApp5.ComplexClass
{
    public static class MainProgram
    {
        public static int Main()
        {
            Driver myDriver = new Driver("Liashenko Rostyslav",17,5);
            Engine myEngine = new Engine(200,"BMW");
            Car.Car myCar = new Car.Car(myEngine,myDriver,"Lux","BMW");
            Console.WriteLine(myCar);
            return 0;
        }
    }
}
