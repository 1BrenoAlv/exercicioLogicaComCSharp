using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.manzano66
{
    internal class Ex07Manzano66
    {
        public static void Main(string[] args)
        {
            int number = 3, potencia = 1;
            Console.WriteLine("Potência de 3.");
            for (int i = 0; i < 16; i++) {
                potencia *= number;
                Console.WriteLine($"{number}^{i} = {potencia}");
            }
        }
    }
}
