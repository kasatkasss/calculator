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
            string operationIndex;
            string[] listOFOperations = { "Сложение", "Вычитание", "Умножение", "Деление" }; 
            do 
            {
                Console.WriteLine("Выберите тип операции: \nСложение \nВычитание \nУмножение \nДеление");
                operationIndex = Console.ReadLine();
            }
            while (!listOFOperations.Contains(operationIndex));

            Methods calculator = new Methods();

            Methods.Operations operationType = calculator.GetOperationType(operationIndex); 
            int result = calculator.Calculate(firstNum, secondNum, operationType);
            Console.WriteLine($"результат операции равен {result}");
            Console.ReadKey();
        }
    }
}
