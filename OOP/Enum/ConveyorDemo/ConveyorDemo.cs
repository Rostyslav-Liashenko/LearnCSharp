namespace LearnEnum
{
    class ConveyorDemo
    {
        static void Main()
        {
            ConveyorControl c = new ConveyorControl();
            c.Conveyor(ConveyorControl.Action.Start);
            c.Conveyor(ConveyorControl.Action.Stop);
            c.Conveyor(ConveyorControl.Action.Forward);
            c.Conveyor(ConveyorControl.Action.Reverse);
        }
    }
}
