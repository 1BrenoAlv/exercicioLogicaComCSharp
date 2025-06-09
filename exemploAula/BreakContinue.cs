using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class BreakContinue
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Break");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Continue");
            int contadorContinue = 0;
            while (contadorContinue < 10)
            {
                if (contadorContinue == 7) 
                { 
                    contadorContinue++;
                    continue;
                }
                Console.WriteLine(contadorContinue);
                contadorContinue++;
            }
        }
    }
}
