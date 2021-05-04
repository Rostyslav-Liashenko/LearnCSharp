using System;

namespace ConsoleApp1
{
    public class Building
    {
        private int Floors;
        private int Area;
        private int Occupants;

        public Building(int floors, int area, int occupants)
        {
            this.Floors = floors ;
            this.Area = area;
            this.Occupants = occupants;
        }
        public int AreaPerPerson()
        {
            return  Area / Occupants;
        }

        public int MaxOccupant(int minArea)
        {
            return Area / minArea;
        }

        public void Show()
        {
            Console.WriteLine("have \n " +
                                          Floors + " floors\n " +
                                          Occupants + " Occupants\n " +
                                          Area +
                                          " Area " + AreaPerPerson() + " for one people " + 
                                          MaxOccupant(300) + " - max count people if min area for one " +
                                          "people = 300");
        }
    }
}
