using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Chapter2Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            exercise2();
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
    }
}
