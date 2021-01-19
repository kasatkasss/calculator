using System;

namespace AreaCalculations
{
    public class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Выберите фигуру, площадь которой хотите вычислить: \nКвадрат \nПрямоугольник");
            string figure = Console.ReadLine();
            if(figure == "Квадрат")
            {
                Console.WriteLine("Введите длину стороны квадрата:");
                square.side = Convert.ToInt32(Console.ReadLine());
                int squareResult = square.GetArea();
                Console.WriteLine($"Площадь квадрата равна: {squareResult}");

                
            }
            else if(figure == "Прямоугольник")
            {
                Console.WriteLine("Введите длину:");
                rectangle.height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите ширину:");
                rectangle.width = Convert.ToInt32(Console.ReadLine());
                int rectangleResult = rectangle.GetArea();
                Console.WriteLine($"Площадь Прямоугольника равна: {rectangleResult}");
            }
            else
            {
                Console.WriteLine("Вы неправильно ввели фигуру");
            }
            Console.ReadKey();


        }
    }
}
