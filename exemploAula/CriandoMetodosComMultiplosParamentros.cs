using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class CriandoMetodosComMultiplosParamentros
    {
        static void Informacoes(string nome,int idade)
        {
            Console.WriteLine($"Nome: {nome}\nIdade: {idade} anos");
        }

        public static void Main(string[] args) 
        {
            Informacoes("Breno", 18);
            Console.WriteLine("----------------");
            Informacoes("Jailson", 40);
            Console.WriteLine("----------------");
            Informacoes("Abel", 19);
        }
    }
}
