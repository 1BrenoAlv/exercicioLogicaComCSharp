using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class Cronometro
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Cronômetro");
            for (int hora = 0; hora < 24; hora++)
            {
                for (int minuto = 0; minuto < 59; minuto++)
                {
                    for (int segundo = 0; segundo < 59; segundo++) 
                    {
                        Console.WriteLine($"{hora} : {minuto} : {segundo}");
                    }
                }
            }
        }
    }
}
