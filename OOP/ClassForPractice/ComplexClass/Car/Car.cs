using System;
using ConsoleApp5.ComplexClass.Details;
using ConsoleApp5.ComplexClass.Professions;

namespace ConsoleApp5.ComplexClass.Car
{
    public class Car
    {
        private Engine engine;
        private Driver driver;
        private string carClass;
        private string marka;

        public Car(Engine engine, Driver driver, string carClass, string marka)
        {
            this.engine = engine;
            this.driver = driver;
            this.carClass = carClass;
            this.marka = marka;
        }

        public Car()
        {
            engine = null;
            driver = null;
            carClass = "";
            marka = "";
        }
        
        public void Start()
        {
            Console.WriteLine("Go!!!");
        }

        public void Stop()
        {
            Console.WriteLine("Stop!!!");
        }

        public void TurnLeft()
        {
            Console.WriteLine("Turn left");
        }

        public void TurnRight()
        {
            Console.WriteLine("Turn right");
        }

        public override string ToString()
        {
            return "--Engine--\n" + engine + "--Driver--\n" + driver + "--Info of car--\n"+"Car class: " 
                   + carClass + "\nMark: " + marka;
        }
    }
}