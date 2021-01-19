using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculations
{
    public class Square : Figure
    {
        public int side;
        public override int Area()
        {
            return side*side;
        }
    }
}
