using System;

namespace AreaCalculations
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите фигуру, площадь которой хотите вычислить: \nКвадрат \nПрямоугольник");
            string figure = Console.ReadLine();
            Calculations calculations = new Calculations();
            Calculations.Figures figureType = calculations.GetFigureType(figure);
            float result = calculations.GetResult(figureType);
            Console.WriteLine($"Площадь Вашей фигуры равна {result}");
            Console.ReadKey();
        }
    }
}
