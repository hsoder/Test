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
            double tal;
            double summa;

            Console.Write("Mata in ett tal: ");
            tal = double.Parse(Console.ReadLine());

            Console.WriteLine(tal/Math.PI);

            summa = (tal + 4.2)/2;
            Console.WriteLine(summa);
            
            Console.Read();
        }
    }
}
