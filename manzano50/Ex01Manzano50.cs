using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.manzano50
{
    internal class Ex01Manzano50
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Número ao quadrado 15 a 200.");
            int i = 15;
            do
            {
                Console.WriteLine($"{i}² = {Math.Pow(i,2)}");
                i++;
            } while (i < 201);
        }
    }
}
