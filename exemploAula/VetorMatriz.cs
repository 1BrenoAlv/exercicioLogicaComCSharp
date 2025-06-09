using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class VetorMatriz
    {
        public static void Main(string[] args)
        {
            string[] carro = { "Toyota", "Honda", "Fiat", "Hyundai" };
            Console.WriteLine(carro[0]);
            carro[0] = "Volvo";
            Console.WriteLine(carro[0]);
            int[] numero = {1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine(numero[0]);
            numero[0] = 0;
            Console.WriteLine(numero[0]);            

            for (int i = 0;i < 4; i++)
            {
                Console.WriteLine(carro[i]);
            }
                Console.WriteLine("\n");
            for (int i = 0; i < numero.Length; i++) 
            { 
                Console.WriteLine(numero[i]);
            }
        }
    }
}
