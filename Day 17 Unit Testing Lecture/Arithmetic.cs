using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_17_Unit_Testing_Lecture
{
    public class Arithmetic
    {
        public int Adder(int x, int y)
        { 
            return x + y; 
        }

        public int Subber(int x, int y)
        {
            return x-y;
        }

        public int Multiply(int x, int y, int z)
        {
            return x*y*z;
        }

        public int Divider (int x, int y)
        { 
            return x/y; 
        }
    }
}
