using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class EspecialCaracter
    {
        public static void Main(string[] args)
        {
            string aspasSimples = "It's \'Maneira correta\'";
            Console.WriteLine(aspasSimples);

            string aspasDuplas = "Colocar um \\\" para colocar um \"";
            Console.WriteLine(aspasDuplas);

            string barra = "Para colocar um \\ temos que colocar \\\\ dentro da string";
            Console.WriteLine(barra);

            string backSpace = "Usando \\b ele apaga a\ba";
            Console.WriteLine(backSpace);

            string pularLinha = "Usando o \\n ele pula linha dentro da string\nEssa frase está à baixo";
            Console.WriteLine(pularLinha);

            string tab = "\tUsando o \\t podemos dar um espaçamento na string como foi feita no inicio da frase.";
            Console.WriteLine(tab);
        }
    }
}
