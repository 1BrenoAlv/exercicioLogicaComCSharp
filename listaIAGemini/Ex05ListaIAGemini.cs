using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.listaIAGemini
{
    internal class Ex05ListaIAGemini
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tabela de Tabuada do 1 ao 10!!");
            int i = 0, j = 0;
            int[,] multiplicacao = new int[10,10];
            for (i = 0; i < multiplicacao.GetLength(0); i++)
            {
                for (j = 0; j < multiplicacao.GetLength(1); j++)
                {
                    multiplicacao[i, j] = (i + 1) * (j + 1);
                    Console.Write($"{multiplicacao[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
