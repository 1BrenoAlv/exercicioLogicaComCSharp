using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class MetodosCSharp
    {
        static void Soma()
        {
            string[] selecao = { "Primeiro Número: ", "Segundo Número: " };
            int[] numeroSoma = new int[2];
            int resultado = 0;
            Console.WriteLine("Digite os valores para Somar!");
            for (int i = 0; i < selecao.Length; i++)
            {
                Console.Write(selecao[i]);
                numeroSoma[i] = Convert.ToInt32(Console.ReadLine());
                resultado += numeroSoma[i];
            }
            Console.WriteLine($"A soma deu: {resultado}");
        }

       public static void Main(string[] args) 
        {
            Console.WriteLine("-------Calculadora-------");
            Soma();
        }
    }
}
