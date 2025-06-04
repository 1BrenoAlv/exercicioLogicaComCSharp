using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.manzano66
{
    internal class Ex05Manzano66
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Números ímpares de 0 a 20.");
            for (int i = 0; i < 21; i++) { 
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
