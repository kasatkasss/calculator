using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculations
{
    public class Rectangle : Figure
    {
        public float width;
        public float height;
        public override float GetArea()
        {
            return height * width;
        }
    }
}
