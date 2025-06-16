using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.listaIAGemini
{
    internal class Ex01listaIAGemini
    {
        public static void Main(string[] args)
        {
            double[] number = new double[5];
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine($"Digite um valor para somar: ");
                number[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine($"O somatório dos números é {number.Sum()}");
        }
    }
}
