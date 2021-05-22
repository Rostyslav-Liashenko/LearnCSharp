namespace ConsoleApp4
{
    public class Nybble
    {
        private int val;

        public Nybble()
        {
            val = 0;
        }

        public Nybble(int i)
        {
            val = i;
            val = val & 0xF;
        }

        public static Nybble operator +(Nybble op1, Nybble op2)
        {
            Nybble result = new Nybble {val = op1.val + op2.val};
            result.val &= 0xF;
            return result;
        }
        
        public static Nybble operator +(Nybble op1, int op2)
        {
            Nybble result = new Nybble {val = op1.val + op2};
            result.val &= 0xF;
            return result;
        }
        
        public static Nybble operator +(int op1, Nybble op2)
        {
            Nybble result = new Nybble {val = op1 + op2.val};
            result.val &= 0xF;
            return result;
        }

        public static Nybble operator -(Nybble op1, Nybble op2)
        {
            Nybble result = new Nybble {val = op1.val - op2.val};
            result.val &= 0xF;
            return result;
        }
        
        public static Nybble operator -(Nybble op1, int op2)
        {
            Nybble result = new Nybble {val = op1.val - op2};
            result.val &= 0xF;
            return result;
        }
        
        public static Nybble operator -(int op1, Nybble op2)
        {
            Nybble result = new Nybble {val = op1 - op2.val};
            result.val &= 0xF;
            return result;
        }
        
        public static Nybble operator ++(Nybble op)
        {
            Nybble result = new Nybble {val = op.val + 1};
            result.val &= 0xF;
            return result;
        }

        
        
        public static bool operator >(Nybble op1, Nybble op2)
        {
            return op1.val > op2.val;
        }

        public static bool operator <(Nybble op1, Nybble op2)
        {
            return op1.val < op2.val;
        }

        public static implicit operator int(Nybble op)
        {
            return op.val;
        }

        public static implicit operator Nybble(int op)
        {
            return new Nybble(op);
        }
    }
}
