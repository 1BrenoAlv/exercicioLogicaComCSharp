using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class ConversaoTipo
    {
        public static void Main(string[] args)
        {
            int exemplo01 = 2;
            double exemplo02 = 2.3;
            bool exemplo03 = true;

            Console.WriteLine(Convert.ToString(exemplo01));
            Console.WriteLine(Convert.ToInt16(exemplo02));
            Console.WriteLine(Convert.ToString(exemplo03));
        }
    }
}
