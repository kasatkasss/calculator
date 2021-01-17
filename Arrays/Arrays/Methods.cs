﻿using System;

namespace Calculations
{
    public class Methods
    {
        public enum Operations
        {
            Add = 1,
            Subtract,
            Multiply,
            Devide
        }

        public int Calculate(int x, int y, Operations operationType) 
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

        public Operations GetOperationType(string chooseOperation)
        {
            Operations result = 0;
            switch(chooseOperation)
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