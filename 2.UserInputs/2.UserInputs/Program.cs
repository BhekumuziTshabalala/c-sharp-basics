using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.UserInputs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name: ");
            String name = Console.ReadLine();

            Console.Write("Enter Your Surame: ");
            String surname = Console.ReadLine();

            Console.WriteLine("Your name is " + name + " " + surname);


        }
    }
}
