using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class ForEachShort02
    {
        public static void Main(string[] args)
        {
            int[] numero = { 4, 2, 3, 5, 1 };
            Array.Sort(numero); // para deixar em ordem 
            Array.Reverse(numero);// para reverter a ordem acima, assim deixando do ultimo para o primeiro
            foreach (int i in numero)
            {
                Console.WriteLine(i);
            }
        }
    }
}
