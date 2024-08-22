using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Reflection;

namespace Learning.App
{
    /// <summary>
    /// Provides basic arthematic calculation Revesion of concepts
    /// </summary>
    class Calculate
    {
        public static int CalculateFunction()
        {
            Calculator newCalculation = new();

            double number1;
            Console.WriteLine("Enter first number:");
            while (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Invalid input. Please enter the first number again.");
            }
            newCalculation.n1 = number1;

            double number2;
            Console.WriteLine("Enter second number");
            while (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Invalid input. Please enter the second number agian.");
            }
            newCalculation.n2 = number2;

            string operation = getOperation();
            string getOperation()
            {
                while (true)
                {
                    Console.WriteLine("Enter an operation (add, subtract, multiply, divide):");
                    string inputOperator = Console.ReadLine().ToLower();

                    if (inputOperator == "add" || inputOperator == "subtract" || inputOperator == "multiply" || inputOperator == "divide")
                    {
                        return inputOperator;
                    }
                    else
                    {
                        Console.WriteLine("Invalid operator. Please enter one of the following: add, subtract, multiply, divide.");
                    }
                }
            }

            Console.WriteLine(operation);

            MethodInfo methodInfo = typeof(Calculator).GetMethod(operation, Type.EmptyTypes);
            Calc x = (Calc)Delegate.CreateDelegate(typeof(Calc), newCalculation, methodInfo);

            double y = x();

            Console.WriteLine($"Your answer is : {y}");

            return 0;
        }
    }

    public delegate double Calc();
    class Calculator
    {
        public double n1, n2;

        public double add()
        {
            double sum = n1 + n2;
            return sum;
        }

        public double subtract()
        {
            double sub = n1 - n2;
            return sub;
        }

        public double divide()
        {
            double divide = n1 / n2;
            return divide;
        }

        public double multiply()
        {
            double multiply = n1 * n2;
            return multiply;
        }
    }
}