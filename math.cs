using System;

namespace MathOperations
{
    class Calculator
    {
        // Method to perform addition
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Method to perform subtraction
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Method to perform multiplication
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Method to perform division
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            double num1 = 10;
            double num2 = 5;

            Console.WriteLine("Addition: " + calculator.Add(num1, num2));
            Console.WriteLine("Subtraction: " + calculator.Subtract(num1, num2));
            Console.WriteLine("Multiplication: " + calculator.Multiply(num1, num2));
            Console.WriteLine("Division: " + calculator.Divide(num1, num2));
        }
    }
}
