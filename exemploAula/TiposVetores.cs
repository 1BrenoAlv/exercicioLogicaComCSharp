using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class TiposVetores
    {
        public static void Main(string[] args)
        {
            string[] carro = new string[3];
            for (int i = 0; i < carro.Length; i++) 
            { 
                Console.Write("Digite a marca do seu carro: ");
                carro[i] = Console.ReadLine();
            }
            for (int i = 0; i < carro.Length; i++) 
            { 
                Console.WriteLine(carro[i]);
            }

            int[] numero = new int[3] {1,2,3};

            string[] aluno = new string[] { "Breno", "Michel Jackson", "Enzo" };

            int[] idade = {18,21,19};
            
        }
    }
}
