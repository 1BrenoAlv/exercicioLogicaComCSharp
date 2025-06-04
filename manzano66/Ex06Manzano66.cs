using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.manzano66
{
    internal class Ex06Manzano66
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Números divisíveis por 4 menores que 200.");
            for (int i = 0; i < 201; i++) { 
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
