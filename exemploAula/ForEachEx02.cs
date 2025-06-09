using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class ForEachEx02
    {
        public static void Main(string[] args)
        {
            string[] aluno = { "Breno", "Michel", "Enzo", "Abel", };
            foreach (string nome in aluno)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
