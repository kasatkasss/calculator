using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculations
{
    /// <summary>
    /// Class for define figure type and 
    /// </summary>
    class Calculations
    {
        Square square = new Square();
        Rectangle rectangle = new Rectangle();
        public enum Figures
        {
            Square = 1,
            Rectangle
        }
        /// <summary>
        /// This class defines the type of figure and, depending on the type, gives the area of this figure.
        /// </summary>
        /// <param name="figure"></param>
        /// <returns></returns>
        public Figures GetFigureType(string figure) 
        {
            Figures result = 0;
            switch (figure)
            {
                case "Квадрат":
                    result = Figures.Square;
                    break;
                case "Прямоугольник":
                    result = Figures.Rectangle;
                    break;
            }
            return result;
        }
        /// <summary>
        ///  Take the type of figure and gets its area.
        /// </summary>
        /// <param name="figureType"></param>
        /// <returns></returns>
        public float GetResult(Figures figureType)
        {
            float result = 0;
            switch (figureType)
            {
                case Figures.Square:
                    Console.WriteLine("Введите длину стороны квадрата:");
                    square.side = Convert.ToSingle(Console.ReadLine());
                    result = square.GetArea();
                    break;
                case Figures.Rectangle:
                    Console.WriteLine("Введите длину:");
                    rectangle.height = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Введите ширину:");
                    rectangle.width = Convert.ToSingle(Console.ReadLine());
                    result = rectangle.GetArea();
                    break;
            }
            return result;   
        }
    }
}
