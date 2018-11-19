using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            int number;
            uint userDefined;

            Console.WriteLine("Welcome to FizzBuzz!");
            Console.WriteLine("Please choose an ending value for the game.");

            while (!uint.TryParse(Console.ReadLine(), out userDefined))
            {
                Console.WriteLine("Please only enter numbers.");
                Console.WriteLine("The number must be positive.");
            }

            for (number = 1; number <= userDefined; number++)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine($"{number}");
                }
            }

            Console.WriteLine("Please press any key to continue.");
            Console.ReadKey();
        }
    }
}
