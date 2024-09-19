using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaratorinis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int symNr, lineNr;
            char symbol;

            Console.Write("Įveskite simbolių skaičių: ");
            symNr = int.Parse(Console.ReadLine());

            Console.Write("Įveskite eilučių skaičių: ");
            lineNr = int.Parse(Console.ReadLine());

            Console.Write("Įveskite simbolį: ");
            symbol = char.Parse(Console.ReadLine());
            Console.WriteLine();

           
            for (int i = 1; i <= lineNr/symNr; i++)
            {
                
                for (int j = 1; j <= symNr; j++)
                {
                    Console.Write(symbol); 
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
