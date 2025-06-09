using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class MatrizMudandoValores
    {
        public static void Main(string[] args)
        {
            string[,] nome = { {"Breno","Jailson" },{ "Felipe", "Abel" } };
            Console.WriteLine(nome[0,1]);
            nome[0, 1] = "Fulano";
            Console.WriteLine(nome[0, 1]);
        }
    }
}
