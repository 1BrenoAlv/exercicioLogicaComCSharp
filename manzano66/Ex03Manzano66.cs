using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.manzano66
{
    internal class Ex03Manzano66
    {
        public static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Soma de 0 até 100!");
            for (int i = 0; i < 101; i++)
            {
                number += i;
            }
            Console.WriteLine($"A soma dos cem primeiros números é {number}");
        }
    }
}
