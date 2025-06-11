using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class Professor01
    {
        string nome = "Arlindo";
        string nacionalidade = "Brasileira";
        string estado = "SP";

        public static void Main(string[] args)
        {
            Professor01 professor00 = new Professor01();
            Professor01 professor01 = new Professor01();

            Console.WriteLine($"Nome: {professor00.nome}\nNaciolanidade: {professor00.nacionalidade}\nEstado: {professor00.estado}");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"Nome: {professor01.nome}\nNaciolanidade: {professor01.nacionalidade}\nEstado: {professor01.estado}");

        }
    }
}
