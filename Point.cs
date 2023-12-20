using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AccessModifier
{
    internal class Point
    {
        public int x = 25;
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
            PrintX();
            PrintY();
        }
    }
}
