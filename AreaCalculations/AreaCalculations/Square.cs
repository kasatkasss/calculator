using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculations
{
    public class Square : Figure
    {
        public float side;
        public override float GetArea()
        {
            return side*side;
        }
    }
}
