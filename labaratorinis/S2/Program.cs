using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sym;
            double first, second;

            Console.WriteLine("--------------------");
            Console.WriteLine("Mini skaičiuotuvas");
            Console.WriteLine("--------------------");
            Console.WriteLine();
            Console.WriteLine("Įveskite norimą operaciją(-,/,+,*): ");
            sym = char.Parse(Console.ReadLine());
            Console.WriteLine("Įveskite pirmąjį skaičių: ");
            first = double.Parse(Console.ReadLine());
            Console.WriteLine("Įveskite pirmąjį skaičių: ");
            second = double.Parse(Console.ReadLine());

            if (sym == '-')
            {
                double minus;
                minus = first - second;

                Console.WriteLine("{0} - {1} = {2}", first, second, minus);
            }
            else if (sym == '+')
            {
                double plus;
                plus = first + second;
                Console.WriteLine("{0} + {1} = {2}", first, second, plus);
            }
            else if (sym == '/')
            {
                double div;
                div = first / second;
                Console.WriteLine("{0} / {1} = {2}", first, second, div);
            }
            else if (sym == '*')
            {
                double multi;
                multi = first * second;
                Console.WriteLine("{0} * {1} = {2}", first, second, multi);
            }
            else
            {
                Console.WriteLine("Klaidinga operacija");
            }
            
            Console.ReadKey();
        }
    }
}
