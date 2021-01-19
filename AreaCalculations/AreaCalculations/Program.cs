using System;

namespace AreaCalculations
{
    public class Program
    {
        static void Main(string[] args)
        {
            Square side = new Square();
            Rectangle sides = new Rectangle();
            Console.WriteLine("Выберите фигуру, площадь которой хотите вычислить: \nКвадрат \nПрямоугольник");
            string figure = Console.ReadLine();
            if(figure == "Квадрат")
            {
                Console.WriteLine("Введите длину стороны квадрата:");
                side.side = Convert.ToInt32(Console.ReadLine());
                int squareResult = side.Area();
                Console.WriteLine($"Площадь квадрата равна: {squareResult}");

                
            }
            else if(figure == "Прямоугольник")
            {
                Console.WriteLine("Введите длину:");
                sides.height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите ширину:");
                sides.width = Convert.ToInt32(Console.ReadLine());
                int rectangleResult = sides.Area();
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
