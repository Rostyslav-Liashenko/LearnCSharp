using System;

namespace LearnEnum
{
    public class ConveyorControl
    {
        public enum Action
        {
            Start,
            Stop,
            Forward,
            Reverse
        };

        public void Conveyor(Action com)
        {
            switch (com)
            {
                case Action.Start:
                    Console.WriteLine("The conveyor start");
                    break;
                case Action.Stop:
                    Console.WriteLine("The conveyor stop");
                    break;
                case Action.Forward:
                    Console.WriteLine("Move the conveyor forward");
                    break;
                case Action.Reverse:
                    Console.WriteLine("Reverse conveyor");
                    break;
            }
        }
    }
}
