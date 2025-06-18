using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class ExConstrutor01
    {
        public string marca;
        public string modelo;
        public int dataLancamento;

       public ExConstrutor01(string marcaCarro,string modeloCarro, int dataLancamentoCarro) 
        {
            marca = marcaCarro;
            modelo = modeloCarro;
            dataLancamento = dataLancamentoCarro;
        }

        public static void Main(string[] args)
        {
            ExConstrutor01 toyota = new ExConstrutor01("Toyota","Corolla",2025);
            Console.WriteLine($"Marca: {toyota.marca}\nModelo: {toyota.modelo}\nLançamento: {toyota.dataLancamento}");
        }
    }
}
