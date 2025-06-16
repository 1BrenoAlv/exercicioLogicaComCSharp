using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.listaIAGemini
{
    internal class Ex02ListaIAGemini
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Maior valor do vetor!");
            //double[] number = {1.2,9.5,23 };
            //foreach (double i in number) 
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine($"Maior número do vetor é: {number.Max()}");


            Console.WriteLine("Digite números aleatórios e descubra o maior valor!");
            double[] number = new double[6];
            int i = 0;
            foreach (double vetorNumber in number)
            {
                number[i] = Convert.ToDouble(Console.ReadLine());
                i++;
            }
            Console.WriteLine($"Maior número do vetor é: {number.Max()}");
        }
    }
}
