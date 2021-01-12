using System;
using System.Linq;

namespace Arrays
{
    public class Calculator 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int firstNum = Convert.ToInt32(Console.ReadLine()); // use camelCase - Done
            Console.WriteLine("Введите второе число:");
            int secondNum = Convert.ToInt32(Console.ReadLine()); // use camelCase - Done
            string operationIndex;
            string[] array = { "Сложение", "Вычитание", "Умножение", "Деление" }; // incorrect logic of condition. this block of code doesn't work as expected - Done.
            do 
            {
                Console.WriteLine("Выберите тип операции: \nСложение \nВычитание \nУмножение \nДеление");
                operationIndex = Console.ReadLine();
            }
            while (!array.Contains(operationIndex));
            Browser calculator = new Browser();

            Browser.Operations operationType = calculator.GetOperationType(operationIndex);
            int result = calculator.Calculate(firstNum, secondNum, operationType);
            Console.WriteLine($"результат операции равен {result}");
            Console.ReadKey();
        }
    }
}
