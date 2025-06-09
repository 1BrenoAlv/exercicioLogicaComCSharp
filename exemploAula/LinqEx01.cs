using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class LinqEx01
    {
        public static void Main(string[] args)
        {
        double[] idade = { 19, 21, 19, 20, 18, 18 };
            Console.WriteLine($"A menor idade na sala é {idade.Min()}");
            Console.WriteLine($"A maior idade na sala é {idade.Max()}");
            Console.WriteLine($"Somando todas as idades dos {idade.Length} é {idade.Sum()}");
            Console.WriteLine($"A media da sala é {idade.Sum()/idade.Length}");

        }

    }
}
