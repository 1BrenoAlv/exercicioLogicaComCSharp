using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.manzano46
{
    internal class Ex03Manzano46
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Soma dos números pares até 500.");
            int i = 0, totalSoma = 0;
            while (i < 501)
            {
                totalSoma += i;
                i += 2;
            }
            Console.WriteLine($"A soma dos números pares até 500 é {totalSoma}");
        }
    }
}
