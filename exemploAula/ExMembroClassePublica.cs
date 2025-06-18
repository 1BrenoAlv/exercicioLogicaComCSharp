using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class ExMembroClassePublica
    {
        public static void Main(string[] args)
        {
            ExMembroClassePublica02 breno = new ExMembroClassePublica02();
            breno.nome = "Breno";
            breno.altura = 1.88D;
            breno.idade = 18;
            Console.WriteLine($"Nome:{breno.nome}\nIdade:{breno.idade}\nAltura:{breno.altura}\n{breno.Equipe2()}");
        }
    }
}
