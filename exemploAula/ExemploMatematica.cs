using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class ExemploMatematica
    {
        public static void Main(string[] args)
        {
            // Math.Max mostra o maior valor que está entre os numeros (Num1 - Num2)
            Console.WriteLine(Math.Max(4, 2));

            // Math.Min mostra o menor valor entre os numeros (Num01 - Num02)
            Console.WriteLine(Math.Min(4, 2));

            // Math.Sqrt mostra a raiz quadrada de um valor apresentado
            Console.WriteLine(Math.Sqrt(144));

            // Math.Abs retorna o valor absoluto de um número
            Console.WriteLine(Math.Abs(-10.01));

            // Math.Round arredonda o valor de um número
            Console.WriteLine(Math.Round(8.70));
        }
    }
}
