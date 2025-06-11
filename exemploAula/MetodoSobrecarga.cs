using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class MetodoSobrecarga
    {
        //static int SomaInt(int numero01,int numero02)  // JEITO ERRADO DE SE FAZER 
        //{
        //    return numero01 + numero02;
        //}

        //static double SomaDouble(double numero01, double numero02)
        //{
        //    return numero01 + numero02;
        //}

        //static string SomaString(string numero01, string numero02)
        //{
        //    return numero01 + numero02;
        //}

        static int Soma(int numero01, int numero02)
        { 
            return numero01 + numero02;
        }

        static double Soma(double numero01, double numero02)
        {
            return numero01 + numero02;
        }

        static string Soma(string numero01, string numero02)
        {
            return numero01 + numero02;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("O primeiro soma com numeros inteiros: ");
            Console.WriteLine(Soma(5,5));
            Console.WriteLine("O segundo soma com numeros decimais: ");
            Console.WriteLine(Soma(7.5D,2.5D));
            Console.WriteLine("O terceiro soma com textos: ");
            Console.WriteLine(Soma("5","5"));
        }
    }
}
