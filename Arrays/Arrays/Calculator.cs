using System;
using System.Linq;

namespace Calculations 
{
    public class Calculator 
    {                                                                          
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int firstNum = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Введите второе число:");
            int secondNum = Convert.ToInt32(Console.ReadLine()); 
            string chooseOperation;
            string[] array = { "Сложение", "Вычитание", "Умножение", "Деление" }; 
            do 
            {
                Console.WriteLine("Выберите тип операции: \nСложение \nВычитание \nУмножение \nДеление");
                chooseOperation = Console.ReadLine();
            }
            while (!array.Contains(chooseOperation));

            Methods calculator = new Methods();

            Methods.Operations operationType = calculator.GetOperationType(chooseOperation); 
            int result = calculator.Calculate(firstNum, secondNum, operationType);
            Console.WriteLine($"результат операции равен {result}");
            Console.ReadKey();
        }
    }
}
