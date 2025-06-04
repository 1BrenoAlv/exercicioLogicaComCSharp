using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.manzano46
{
    internal class Ex01Manzano46
    {
        public static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("Tabuada!");
            Console.Write("Digite um número: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (i < 11)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
                i++;
            }
        }
    }
}
