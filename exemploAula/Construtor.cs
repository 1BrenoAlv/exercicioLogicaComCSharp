using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class Construtor
    {
        public string idadeAluno;

        public Construtor(string idade)
        {
            idadeAluno = idade;
        }

        public static void Main(string[] args)
        {
            Construtor breno = new Construtor("18");
            Console.WriteLine($"A minha idade é {breno.idadeAluno}");
        }
    }
}
