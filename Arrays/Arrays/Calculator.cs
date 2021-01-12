using System;
using System.Linq;

namespace Calculations //can I give different namespaces names in different classes, or they must be the same? 
{
    public class Calculator 
    {                                                                         //it is good idea, to write comments in english 
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int firstNum = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Введите второе число:");
            int secondNum = Convert.ToInt32(Console.ReadLine()); 
            string operationIndex;
            string[] array = { "Сложение", "Вычитание", "Умножение", "Деление" }; 
            do 
            {
                Console.WriteLine("Выберите тип операции: \nСложение \nВычитание \nУмножение \nДеление");
                operationIndex = Console.ReadLine();
            }
            while (!array.Contains(operationIndex));
            forCalculations.Methods calculator = new forCalculations.Methods();

            forCalculations.Methods.Operations operationType = calculator.GetOperationType(operationIndex);  //is it right?(forCalculations.Methods.Operations blablabla...
            int result = calculator.Calculate(firstNum, secondNum, operationType);
            Console.WriteLine($"результат операции равен {result}");
            Console.ReadKey();
        }
    }
}
