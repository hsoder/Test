using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in ett tal: ");
            int taL = int.Parse(Console.ReadLine());

            Console.WriteLine("Summan är " + (taL + taL));

            Console.WriteLine("TEST!COmmit 7777");//Output text in console
            for (int i = 0; i < 10; i++)//Repeats 10 times
            {
                Console.WriteLine("HEJ DÅ!!");//Text to be shown i times
            }
        }
    }
}
