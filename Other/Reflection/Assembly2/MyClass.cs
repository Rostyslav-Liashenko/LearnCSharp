using System;
    public class MyClass
    {
        private int x;
        private int y;

	public MyClass(int i)
	{
	   Console.WriteLine("Constructor with 1 parameter");
	   x = y = i;
	   Show();
	}

        public MyClass(int i, int j)
        {
	    Console.WriteLine("Constructor with 2 parameter");
            x = i;
            y = j;
	    Show();
        }

        public int Sum()
        {
            return x + y;
        }

        public bool IsBetween(int i)
        {
            return (x < i && i < y);
        }

        public void Set(int a, int b)
        {
            Console.WriteLine("In method Set(int a, int b)");
            x = a;
            y = b;
            Show();
        }

        public void Set(double a, double b)
        {
            Console.WriteLine("In method Set(double a, double b)");
            x = (int) a;
            y = (int) b;
            Show();
        }

        public void Show()
        {
            Console.WriteLine("Value x: {0}, value y: {1}", x, y);
        }
    }
    
    public class AnotherClass
    {
	private string msg;
	
	public AnotherClass(string str)
	{
	   msg = str;
	}
	

	public void Show()
	{
	   Console.WriteLine(msg);
	}
    }
