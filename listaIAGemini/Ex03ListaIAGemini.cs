using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.listaIAGemini
{
    internal class Ex03ListaIAGemini
    {
        public static void Main(string[] args)
        {
            string[] nome = new string[5];
            Console.WriteLine("Digite uma palavra e veja ela invertida!");
            for (int i = 0; i < nome.Length; i++)
            {
                nome[i] = Console.ReadLine();
                nome[i] = new string(nome[i].Reverse().ToArray());
                Console.WriteLine($"Palavra invertida é {nome[i]}");
            }
        }
    }
}
