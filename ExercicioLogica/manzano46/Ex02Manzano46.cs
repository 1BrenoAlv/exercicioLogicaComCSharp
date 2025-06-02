using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.manzano46
{
    internal class Ex02Manzano46
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Soma dos 100 primeiros números.");
            int i = 1, totalSoma = 0;
            while (i < 101) { 
                totalSoma += i;
                i++;
            }
            Console.WriteLine($"A soma dos 100 primeiros números é {totalSoma}");
        }
    }
}
