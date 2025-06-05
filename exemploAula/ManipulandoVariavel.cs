using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class ManipulandoVariavel
    {
        public static void Main(string[] args)
        {
            string name = "Breno Alves";
            int letraPosicao = name.IndexOf("B"); // IndexOf para saber onde esta a letra
            string nomePrimeiro = name.Substring(letraPosicao, 5); // Ele mostra apartir de tal letra (ou casa)
            string sobrenome = name.Substring(letraPosicao + 6);
            //Console.WriteLine(name[2]);
            //Console.WriteLine(letraPosicao); 
            Console.WriteLine($"Meu nome é {nomePrimeiro} e meu sobrenome é {sobrenome}");
            
        }
    }
}
