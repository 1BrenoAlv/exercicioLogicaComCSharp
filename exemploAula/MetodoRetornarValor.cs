using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class MetodoRetornarValor
    {
        static int Soma(int numero01, int numero02)
        {
            return numero01 + numero02;
        }

        public static void Main(string[] args)
        {
            int[] numero = new int[2];
            Console.Write("Digite um numero: ");
            numero[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite outro numero:");
            numero[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{numero[0]} + {numero[1]} = {Soma(numero[0], numero[1])}");
        }
    }
}
