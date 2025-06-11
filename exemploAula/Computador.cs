using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class Computador
    {
        string processador =  "AMD Ryzen 5 5500" ;
        string placaVideo = "RTX 4060 TI" ;
        string memoriaRam = "16 ram";
        int armazenamentoInterno = 512;

        public static void Main(string[] args)
        {
            Computador tecnologia = new Computador();
            Console.WriteLine($"Processador: {tecnologia.processador}\nPlaca de Video: {tecnologia.placaVideo}\nMemoria Ram: {tecnologia.memoriaRam}\nSSD: {tecnologia.armazenamentoInterno}");
        }
    }
}
