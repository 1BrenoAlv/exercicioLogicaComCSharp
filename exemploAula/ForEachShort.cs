using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class ForEachShort
    {
        public static void Main(string[] args)
        {
            string[] nome = { "Breno", "Abel", "Michel", "Enzo" };
            Array.Sort(nome);
            foreach (string aluno in nome) {
                Console.WriteLine(aluno);
            }
        }
    }
}
