using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj.");

            int broj = int.Parse( Console.ReadLine());

            if (broj % 3 == 0 && broj % 5 != 0)
            {
                Console.WriteLine("Fizz :)");
            }
            else if (broj % 5 == 0 && broj % 3 != 0)
            {
                Console.WriteLine("Buzz :)");
            }
            else if (broj % 3 == 0 && broj % 5 == 0)
            {
                Console.WriteLine("FizzBuzz ;)");
            }
            else
            {
                Console.WriteLine("Tvoj broj nije zanimljiv :D");

            }
            Console.ReadKey();
        }
    }
}
