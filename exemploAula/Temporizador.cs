using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica.exemploAula
{
    internal class Temporizador
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Temporizador! (1 minuto!) "); //Temporizador basico de 1 minuto!!

            //for (int i = 59; i > - 1; i--)
            //{
            //    Console.WriteLine($"0:{i}");
            //}

            Console.WriteLine("Temporizador!");
            Console.Write("Digite as horas: ");
            int hora = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite os minutos: ");
            int minuto = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite os segundos: ");
            int segundo = Convert.ToInt32(Console.ReadLine());
            int horaDigitada = hora, minutoDigitado = minuto, segundoDigitado = segundo;


            if (horaDigitada < 24 && minutoDigitado < 60 && segundoDigitado < 60) {
                for (horaDigitada = horaDigitada; horaDigitada > -1; horaDigitada--)
                {
                    for (minutoDigitado = minutoDigitado; minutoDigitado > -1; minutoDigitado--)
                    {
                        for (segundoDigitado = segundoDigitado; segundoDigitado > -1; segundoDigitado--)
                        {
                            Console.WriteLine($"{horaDigitada} : {minutoDigitado} : {segundoDigitado}");
                        }segundoDigitado = 59;
                    } minutoDigitado = 59;
                }
            }
            else
            {
                do
                {
                    Console.WriteLine("Os valores digitados são inválidos!");
                    Console.WriteLine("Horas => 0 até 23.\nMinutos => 0 até 59.\nSegundos => 0 até 59.");
                    Console.Write("Digite as horas novamente: ");
                    horaDigitada = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite os minutos novamente: ");
                    minutoDigitado = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite os segundos novamente: ");
                    segundoDigitado = Convert.ToInt32(Console.ReadLine());
                } while (!(horaDigitada < 24 && minutoDigitado < 60 && segundoDigitado < 60));

                for (horaDigitada = horaDigitada; horaDigitada > -1; horaDigitada--)
                {
                    for (minutoDigitado = minutoDigitado; minutoDigitado > -1; minutoDigitado--)
                    {
                        for (segundoDigitado = segundoDigitado; segundoDigitado > -1; segundoDigitado--)
                        {
                            Console.WriteLine($"{horaDigitada} : {minutoDigitado} : {segundoDigitado}");
                        }
                        segundoDigitado = 59;
                    }
                    minutoDigitado = 59;
                }
            }          
        }       
    }
}
