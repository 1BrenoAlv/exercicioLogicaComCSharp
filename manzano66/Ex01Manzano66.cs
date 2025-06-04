using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.manzano66
{
    internal class Ex01Manzano66
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Apresentar os quadrados dos números inteiros de 15 a 200");
            for (int i = 15; i < 201; i++) {
                Console.WriteLine($"{i}² = {Math.Pow(i,2)}");
            }
        }
    }
}
