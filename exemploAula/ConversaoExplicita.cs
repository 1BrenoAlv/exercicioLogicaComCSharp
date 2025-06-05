using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class ConversaoExplicita
    {
        public static void Main(string[] args)
        {
            double number01 = 18.4; 
            int number02 = (int) number01; // ele transforma o double por uma int, ele passa a ser um numero inteiro *18*
            Console.WriteLine(number02);
        }
    }
}
