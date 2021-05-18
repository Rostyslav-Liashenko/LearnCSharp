using System;

namespace ConsoleApp4
{
    public class ThreeD
    {
        private int _x;
        private int _y;
        private int _z;

        public ThreeD()
        {
            _x = _y = _z = 0;
        }

        public ThreeD(int x, int y, int z)
        {
            this._x = x;
            this._y = y;
            this._z = z;
        }

        public static ThreeD operator-(ThreeD op)
        {
            ThreeD result = new ThreeD();
            result._x = -op._x;
            result._y = -op._y;
            result._z = -op._z;
            return result;
        }

        public static ThreeD operator++(ThreeD op)
        {
            ThreeD result = new ThreeD();
            result._x = op._x + 1;
            result._y = op._y + 1;
            result._z = op._z + 1;
            return result;
        }
        
        public static ThreeD operator+(ThreeD op1, ThreeD op2)
        {
            ThreeD result = new ThreeD();
            result._x = op1._x + op2._x;
            result._y = op1._y + op2._y;
            result._z = op1._z + op2._z;
            return result;
        }
        
        public static ThreeD operator+(int op1, ThreeD op2)
        {
            ThreeD result = new ThreeD();
            result._x = op2._x + op1;
            result._y = op2._y + op1;
            result._z = op2._z + op1;
            return result;
        }
        
        public static ThreeD operator+(ThreeD op1, int op2)
        {
            ThreeD result = new ThreeD();
            result._x = op1._x + op2;
            result._y = op1._y + op2;
            result._z = op1._z + op2;
            return result;
        }
        
        public static ThreeD operator-(ThreeD op1, ThreeD op2)
        {
            ThreeD result = new ThreeD();
            result._x = op1._x - op2._x;
            result._y = op1._y - op2._y;
            result._z = op1._z - op2._z;
            return result;
        }
        
        public void Show()
        {
            Console.WriteLine(_x + " " + _y + " " + _z);
        }
    }
}
