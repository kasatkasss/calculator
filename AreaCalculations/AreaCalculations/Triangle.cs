namespace AreaCalculations
{
    public class Triangle : Figure
    {
        public override float GetArea()
        {
            return sideA * sideB/2;
        }
    }
}
