using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.manzano66
{
    internal class Ex08Manzano66
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Potência!");
            Console.Write("Digite o valor da base: ");
            int basePotencia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor do expoente: ");
            int expoente = Convert.ToInt32(Console.ReadLine());
            int potencia = 1;
            for (int i = 1; i <= expoente; i++) {
                potencia *= basePotencia;
            }
            Console.WriteLine($"{basePotencia}^{expoente} = {potencia}");
        }
    }
}
