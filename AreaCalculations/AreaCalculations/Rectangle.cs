using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculations
{
    public class Rectangle : Figure
    {
        public int width;
        public int height;
        public override int Area()
        {
            return height * width;
        }
    }
}
