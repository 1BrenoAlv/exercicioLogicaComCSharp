using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class ForEachMatriz
    {
        public static void Main(string[] args)
        {
            int[,] tabela = { {1,2,3 }, {4,5,6 } };
            for (int i = 0; i < tabela.GetLength(0); i++) {
                for (int j = 0; j < tabela.GetLength(1); j++) 
             //GetLength(numero da coluna) ele é um mostra quantos valores existem dentro de uma matriz
                {
                    Console.WriteLine(tabela[i, j]);
                }
            }

            //foreach (int i in tabela) { 
            //    Console.WriteLine(i);
            //}
        }
    }
}
