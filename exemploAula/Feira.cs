using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class Feira
    {
        public static void Main(string[] args)
        {
            Fruta banana = new Fruta();
            Console.WriteLine($"Nome: {banana.nomeFruta}\nPreço: R${banana.precoFruta}");
        }
    }
}
