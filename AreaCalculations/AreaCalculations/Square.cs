namespace AreaCalculations
{
    public class Square : Figure
    {
        public override float GetArea()
        {
            sideA = sideB;
            return base.GetArea();
        }
    }
}
