using System;

namespace _3.basic_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter Opperation: ");
            char opperation = char.Parse(Console.ReadLine());

            double result = 0;
            bool validCalculation = true;

            switch (opperation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                case '%':
                    result = num1 % num2;
                    break;
                default:
                    Console.WriteLine("case not found");
                    validCalculation = false;
                    break;
            }
            
            if (validCalculation)
            {
                Console.WriteLine(num1 + " " + opperation + " " + num2 + " = " + result);
            }
           
            Console.Read();
        }
    }
}
