namespace ConsoleApp4
{
    class TypeConv
    {
        static void Main()
        {
            Overload2 ob = new Overload2();
            int i = 10;
            double d = 10.1;
            byte b = 99;
            short s = 10;
            float f = 11.5F;
            
            ob.MyMeth(i);
            ob.MyMeth(d);
            ob.MyMeth(b);
            ob.MyMeth(s);
            ob.MyMeth(f);
        }
    }
}
