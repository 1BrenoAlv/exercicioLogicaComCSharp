using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class CriandoMetodosComParamentros
    {
        static void Nome(string nome)
        {
            Console.WriteLine($"{nome} Alves");
        }

        public static void Main(string[] args) {
            Nome("Breno");
            Nome("Jailson");
            Nome("Felipe");
        }
    }
}
