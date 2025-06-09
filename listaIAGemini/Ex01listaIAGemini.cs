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
            int[] number = new int[5];
            int somatorio = 0;
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine($"Digite um valor para somar: ");
                number[i] = Convert.ToInt32(Console.ReadLine());
                somatorio += number[i];
            }
            Console.WriteLine($"O somatório dos números é {somatorio}");
        }
    }
}
