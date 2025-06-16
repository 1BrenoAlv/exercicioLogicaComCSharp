using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class MembroClasse01
    {
        string sexoMembroClasse01 = "Masculino";
        int idadeMembroClasse01 = 18;
        double alturaMembroClasse01 = 1.88D;

        public void Equipe2()
        {
            Console.WriteLine("Equipe 2 é a melhor");
        }

        public static void Main(string[] args)
        {
            MembroClasse01 Breno = new MembroClasse01();
            Console.WriteLine($"Breno\nsexo:{Breno.sexoMembroClasse01}\nidade:{Breno.idadeMembroClasse01}\naltura:{Breno.alturaMembroClasse01}");
            Breno.Equipe2();
        }

    }
}
