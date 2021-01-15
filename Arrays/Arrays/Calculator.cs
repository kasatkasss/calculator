using System;
using System.Linq;
using forCalculations;
using Class1;

namespace Calculations 
{
    public class Calculator 
    {                                                                         //it is good idea, to write comments in english 
        public static void Main(string[] args)
        {
            /*Console.WriteLine("Введите первое число:");
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
            while (!array.Contains(operationIndex));*/
            Entervalues a = GetValues();

            Methods calculator = new Methods();

            Methods.Operations operationType = calculator.GetOperationType(a.operationIndex); 
            int result = calculator.Calculate(a.firstNum, a.secondNum, operationType);
            Console.WriteLine($"результат операции равен {result}");
            Console.ReadKey();
        }

        static Entervalues GetValues()
        {
            Entervalues enter = new Entervalues();
            Console.WriteLine("Enter first number:");
            enter.firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            enter.secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operation type: \nСложение \nВычитание \nУмножение \nДеление");
            enter.operationIndex = Console.ReadLine();
            return enter;
        }
    }
}
