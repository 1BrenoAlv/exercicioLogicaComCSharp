using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.listaIAGemini
{
    internal class Ex04ListaIAGemini
    {
        public static void Main(string[] args)
        {
            string[] palavra = new string[1];
            Console.WriteLine("Contagem de vogais!\nDigite uma palavra:");
            palavra[0] = Console.ReadLine().ToLower();

            int contadorVogais = 0;
            foreach (char letra in palavra[0])
            {
                if ("aeiouáãàéèúùóõò".Contains(letra))
                {
                    contadorVogais++;
                }
            }

            Console.WriteLine($"A palavra digitada tem {contadorVogais} vogais!");
        }
    }
}
