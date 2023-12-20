using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    internal class Point
    {
        public int x;
        private int y = 45;

        private void PrintX()
        {
            Console.WriteLine($"X {x}");
        }

        public void PrintY()
        {
            Console.WriteLine($"Y {y}");
        }

        public void PrintPoint()
        {
            Console.WriteLine();
        }
    }
}
