using System;

namespace ConsoleApp1
{
    class BuildingDemo
    {
        static void Main()
        {
            Building house = new Building(2,2500,4);
            Building office = new Building(3,4200,25);
            Console.WriteLine("House");
            house.Show();
            Console.WriteLine("Office");
            office.Show();
        }
    }
}
