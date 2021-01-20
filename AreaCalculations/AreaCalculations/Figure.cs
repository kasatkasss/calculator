namespace AreaCalculations
{
    public abstract class Figure
    {
        public float sideA;
        public float sideB;

        public virtual float GetArea()
        {
            return sideA * sideB;
        }
    }
}
