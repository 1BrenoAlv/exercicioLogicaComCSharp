using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class ForEach
    {
        public static void Main(string[] args)
        {
            string[] carro = { "Toyota", "Honda", "Fiat", "Hyundai" };
            foreach (string nomeCarro in carro) { 
            Console.WriteLine(nomeCarro);
            }
        }
    }
}
