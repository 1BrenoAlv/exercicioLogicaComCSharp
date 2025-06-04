using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.manzano66
{
    internal class Ex02Manzano66
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tabuada!");
            Console.Write("Digite um número: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{number} x {i} = {number*i}");
            }
        }
    }
}
