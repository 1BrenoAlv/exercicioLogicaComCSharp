using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.manzano50
{
    internal class Ex04Manzano50
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Somatório dos números de grãos de trigo");
            ulong i = 1, trigo = 1, totalTrigo = 0;

            do
            {
                totalTrigo += trigo;
                trigo *= 2;
                i++;
            } while (i <= 64);
            Console.WriteLine($"Somatório de trigos = {totalTrigo}");
        }
    }
}
