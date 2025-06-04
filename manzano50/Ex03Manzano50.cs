using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.manzano50
{
    internal class Ex03Manzano50
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Apresentar números divisiveis por 4 que estão situados entre 1 a 200.");
            int i = 1;
            do
            {
                i++;
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
            }while (i < 201);
        }
    }
}
