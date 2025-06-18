using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class ExGetSetMain
    {
        public static void Main(string[] args)
        {
            ExGetSet breno = new ExGetSet();
            breno.Nome = "Breno";

            Console.WriteLine($"Nome: {breno.Nome}");
        }
    }
}
