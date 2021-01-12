using System;

namespace Arrays //??
{
    public class Browser // Browser?!
    {
        public enum Operations
        {
            Add = 1,
            Subtract,
            Multiply,
            Devide
        }

        public int Calculate(int x, int y, Operations operationType) //why the method is static?
        {
            int result = 0;
            switch (operationType)
            {
                case Operations.Add:
                    result = x + y;
                    break;
                case Operations.Subtract:
                    result = x - y;
                    break;
                case Operations.Multiply:
                    result = x * y;
                    break;
                case Operations.Devide:
                    result = x / y;
                    break;
            }
            return result;
        } 

        public Operations GetOperationType(string operationIndex)
        {
            Operations result = 0;
            switch(operationIndex)
            {
                case "Сложение":
                    result = Operations.Add;
                    break;
                case "Вычитание":
                    result = Operations.Subtract;
                    break;
                case "Умножение":
                    result = Operations.Multiply;
                    break;
                case "Деление":
                    result = Operations.Devide;
                    break;
            }
            return result;
        }
        
    }
}