using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class MetodosComValorPadrao
    {
        static void Pais(string pais = "Brasil")
        {
            Console.WriteLine($"Localidade: {pais}");
        }
        public static void Main(string[] args)
        {
            Pais();
            Pais("Portugal");
        }
    }
}
