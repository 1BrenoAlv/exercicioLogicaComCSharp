using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class MetodoSobrecarga01
    {
        static int Soma(int numero01, int numero02)
        {
            return (numero01 + numero02);
        }

        static double Soma(double numero01, double numero02)
        {
            return (numero01 + numero02);
        }

        public static void Main(string[] args)
        {
            double[] numero = new double[2];
            Console.Write($"Digite um número: ");
            numero[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Digite outro número: ");
            numero[1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{numero[0]} + {numero[1]} = {Soma(numero[0], numero[1])}");

        }
    }
}
