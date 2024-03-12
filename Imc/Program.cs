using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua altura: ");
            double alt = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu peso: ");
            double pes = double.Parse(Console.ReadLine());

            double imc = pes / (alt * alt);

            if (imc < 16.9)
            {
                Console.WriteLine("Seu imc é: " + imc + "está muito abaixo do peso. é preocupante");
            }
            else if(imc < 18.4)
            {
                Console.WriteLine("Seu imc é: " + imc + "você está abaixo do peso. preocupante.");
            }
            else if(imc < 24.9)
            {
                Console.WriteLine("Seu imc é: " + imc + "seu peso está normal. parabéns! continue assim.");
            }
            else if(imc < 29.9)
            {
                Console.WriteLine("Seu imc é: " + imc + "você está acima do peso. cuidado");
            }
            else if(imc < 34.9)
            {
                Console.WriteLine("Seu imc é: " + imc + "você com obesidade grau 1. preocupante");
            }
            else if(imc < 40)
            {
                Console.WriteLine("Seu imc é: " + imc + "você está com obesidade grau 2. é bem preocupante");
            }
            else if(imc > 40)
            {
                Console.WriteLine("Seu imc é: " + imc + "você está com obesidade grau 3. deveria ter procurado um médico no grau 1. se cuide, Thais Carla");
            }

            Console.ReadKey();
        }

    }
}
