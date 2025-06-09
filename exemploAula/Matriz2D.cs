using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class Matriz2D
    {
        public static void Main(string[] args)
        {
            int[,] numero = { { 1, 3, 4, 6 }, { 1, 2, 3, 4 } };
            string[,] nome = { { "Breno", "Abel", "Felipe" }, { "Gustavo", "Enzo", "Luccas" } };
            foreach (int i in numero) { 
            Console.WriteLine(i);
            }
            foreach (string aluno in nome) { 
            Console.WriteLine(aluno);
            }
            Console.WriteLine("------------------------");
            Console.WriteLine(numero[0,2]);
            Console.WriteLine(numero[1,2]);
            Console.WriteLine(nome[0,2]);

        }
    }
}
