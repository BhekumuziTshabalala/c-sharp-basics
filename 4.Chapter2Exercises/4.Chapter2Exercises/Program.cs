using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4.Chapter2Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            exercise7();
        }

        /*
            Develop a program that will take any number of seconds as input and then display the
            equivalent number of hours, minutes and remaining seconds. The output must be
            formatted as HH:nn:ss, e.g. "4000 s = 01:06:40".
         */
         static void exercise1()
         {
            Console.Write("Enter the Number of Seconds: ");
            int seconds = int.Parse(Console.ReadLine());

            int hours = seconds / 3600;
            seconds %= 3600;

            int minutes = seconds / 60;
            seconds %= 60;

            Console.WriteLine(hours.ToString("D2") + ":" +  minutes.ToString("D2") + ":" + seconds.ToString("D2"));
            Console.ReadKey();
         }

        /*
            Develop a program that will take any number of bytes as input and then display the
            equivalent number of gigabytes, megabytes, kilobytes and remaining bytes. Remember
            that there are 1024 bytes in a kilobyte and 1024 kilobytes in a megabyte, etc. Make
            provision for the fact that int can take no more than 2 GB.
         */

        static void exercise2()
        {
            Console.Write("Enter the number of bytes: ");
            long bytes = int.Parse(Console.ReadLine());

            long kilobytes = bytes / 1024;
            bytes %= 1024;

            long megabytes = bytes / 1024;
            bytes %= 1024;

            long gigabytes = bytes / 1024;
            bytes %= 1024;

            Console.WriteLine("GB: " + gigabytes + " MB: " + megabytes + " KB: " + kilobytes + " bytes: " + bytes);
            Console.ReadKey();
        }

        /*
            Develop a currency converter. The program should take two inputs: The exchange rate
            for the amount of South African Rand per US Dollar and an amount of US Dollar. The
            output should be properly formatted with the correct currency units and display the
            equivalent amount of South African Rand. For example, with an exchange rate of
            R6.77/$ and an input of $3, the output should be: "3.00$ = R 20.31".
        */

        static void exercise3()
        {
            Console.Write("Enter the exchange rate: ");
            decimal exchangeRate = decimal.Parse(Console.ReadLine());

            Console.Write("Enter the Amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            
            decimal result = exchangeRate * amount;

            Console.WriteLine(exchangeRate.ToString("F2") + "$" + " = " + "R " + result.ToString("F2"));
            Console.ReadKey();

        }


        /*
            Write a program for the console window that will allow the user to enter 5 numeric
            values. The program must then display the average of the numbers to the nearest two
            decimal digits
         */
        static void exercise4()
        {
            decimal sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number " + i + ": ");
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine("The average is : " + (sum / 5).ToString("F2"));
            Console.ReadKey();

        }
        /*
            Write a program for the console window to allow the user to enter the radius and length
            of a pipe. The program must then display the outer surface area of the pipe
         */

        static void exercise5()
        {
            Console.WriteLine("Enter the radius: ");
            int radius = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length: ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("The outer surface area = " + (2 * (2 * radius) + 2 * (length)));
        }

        /*
            Write a program for the console window for Johnny's Cash Shop. Allow the user to enter
            prices of three items.Calculate and display the total owed.Then allow the user to enter
            the amount offered by the customer and then calculate and display the amount to be
            given as change.
        */
        static void exercise6()
        {
            Console.WriteLine("Johnny's Cash Shop\n");
            decimal sum = 0;

            for (int i = 1; i < 4; i++)
            {
                Console.Write("Enter item Price " + i + " :R");
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine("The price of the items :R" + sum);

            Console.Write("Amount Provided by user :R");
            decimal amount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Change :R" + (amount - sum).ToString("F2"));
            Console.ReadKey();

        }

        /*
            Salesman earns a monthly salary that is compiled as follows:
            Gross pay = R2000 + 15% of all sales
            Nett pay = Gross pay - deductions, where
            Deductions = Tax of R500 + 2% of all sales.
         */
        static void exercise7()
        {
            Console.Write("Enter sales: R ");
            decimal sales = decimal.Parse(Console.ReadLine());
            decimal grossSalary = 2000 + (sales * 13 / 100) - 500;
            Console.WriteLine("Gross Pay: R " + grossSalary.ToString("F2"));
            Console.ReadKey();
        }
    }
}
