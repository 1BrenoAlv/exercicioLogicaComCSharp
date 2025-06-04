using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.manzano50
{
    internal class Ex02Manzano50
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Somatório dos números pares atá 500.");
            int i = 0, totalSoma = 0;
            do
            {
                i++;
                if (i % 2 == 0)
                {
                    totalSoma += i;
                }
            } while (i < 501);
            Console.WriteLine(totalSoma);
        }
    }
}
