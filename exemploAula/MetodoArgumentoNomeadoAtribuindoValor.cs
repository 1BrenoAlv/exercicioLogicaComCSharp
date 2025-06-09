using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class MetodoArgumentoNomeadoAtribuindoValor
    {
        static void Nome(string nome01,string nome02,string nome03)
        {
            Console.WriteLine($"A crinça mais jovem é {nome02}");
        }

        public static void Main(string[] args)
        {
            Nome //muito parecido com o props do REACT JS
                (
                nome03: "Breno",
                nome01: "Felipe", 
                nome02: "Jailson"
                );
        }
    }
}
