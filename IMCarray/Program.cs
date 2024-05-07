using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            double[] peso = new double[5];
            double[] altura = new double[5];
            double[] imc = new double[5];
            double cont = 0;
            for (int i = 0; i <= 4; i++) 
            {
                Console.WriteLine("Insira seu nome: ");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Insira seu peso: ");
                peso[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira sua altura em metros: ");
                altura[i] = double.Parse(Console.ReadLine());
                imc[i] = peso[i] / (altura[i] * altura[i]);
                Console.WriteLine("Seu IMC é: " + imc[i]);
                if (imc[i] < 18.5)
                {
                    Console.WriteLine("Abaixo do peso");
                }
                else if (imc[i] < 24.9)
                {
                    Console.WriteLine("Peso ideal");
                }
                else if (imc[i] < 29.9)
                {
                    Console.WriteLine("Levemente acima do peso");
                    cont++;
                }
                else if (imc[i] < 34.9)
                {
                    Console.WriteLine("Obesidade grau I");
                    cont++;
                }
                else if (imc[i] < 39.9)
                {
                    Console.WriteLine("Obesidade grau II (severa)");
                    cont++;
                }
                else if (imc[i] > 40)
                {
                    Console.WriteLine("Obesidade grau III (mórbida)");
                    cont++;
                }
      
            }
            for (int j = 0; j <= 4; j++)
            {
                Console.WriteLine(nome[j] + " IMC: " + imc[j]);

            }
            Console.WriteLine("Estão acima do peso: " + cont + "   " + (cont/5)*100);
            Console.ReadKey();

        }
    }
}
