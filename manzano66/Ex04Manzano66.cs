using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.manzano66
{
    internal class Ex04Manzano66
    {
        public static void Main(string[] args)
        {
            int totalSoma = 0, i;
            Console.WriteLine("Somatório dos valores pares até 500!");
            for (i = 0; i < 501; i++)
            {
                if (i % 2 == 0)
                {
                    totalSoma += i;
                }
            }
            Console.WriteLine($"O somatórios dos valores pares até 500 é {totalSoma}");
        }
    }
}
