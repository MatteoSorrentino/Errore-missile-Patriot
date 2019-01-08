using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // x = 1 / 10 = (0,1) = (0.0001100110011...)

            // x~ = (0.00011001100110011001100) 

            double spazio = 0;

            int velocità = 1676;

            double tempo = 0;

            // E=x-x~ = (0.00000000000000000000000110011...)

            double E = 0.000000095;

            tempo = E * 100 * 60 * 60 * 10;

            spazio = velocità * tempo;

            Console.WriteLine($" {spazio} è l'errore in secondi che fece il missile Patriot");


            Console.ReadLine();
        }
    }
}
