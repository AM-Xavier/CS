using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleOOP
{
    internal class Rectangle
    {
        // area = lenght x width
        // perimeter = 2 * (lenght + width)
        // diagonal = sqroot(lenght**2 + width**2)

        public double Lenght, Width;

        public double Area()
        {
            return Lenght * Width;
        }

        public double Perimeter()
        {
            return 2 * (Lenght + Width);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Lenght, 2)) + (Math.Pow(Width, 2));
        }

    }
}
