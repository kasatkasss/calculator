using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculations
{
    public class Square : Figure
    {
        public int side;
        public override int GetArea()
        {
            return side*side;
        }
    }
}
