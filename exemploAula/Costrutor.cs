using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class Costrutor
    {
        public string idadeAluno;

        public Costrutor(string idade)
        {
            idadeAluno = idade;
        }

        public static void Main(string[] args)
        {
            Costrutor breno = new Costrutor("18");
            Console.WriteLine($"A minha idade é {breno.idadeAluno}");
        }
    }
}
