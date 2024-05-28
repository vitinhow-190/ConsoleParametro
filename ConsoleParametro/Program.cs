using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleParametro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro valor: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a operação desejada [adição, subtração, multiplicação ou divisão]:");
            string op = Console.ReadLine();

             operação(n1, n2, op);

            Console.ReadKey();
        }
        static void operação(double n1, double n2,string op) 
        {
           switch (op)
           {
                case "adição":

                    double resultado = n1 + n2;

                    Console.WriteLine("O resultado da soma é: " + resultado);
                    break;

                case "subtração":

                    double resultado2 = n1 - n2;

                    Console.WriteLine("O resultado da subtração é: " + resultado2);
                    break;

                case "multiplicação":

                    double resultado3 = n1 * n2;

                    Console.WriteLine("O resultado da multiplicação é: " + resultado3); 
                    break;

                case "divisão":

                    double resultado4 = n1 / n2;

                    Console.WriteLine("O resultado da divisão é: " + resultado4);
                    break;

                 
           }
            Console.ReadKey ();
        }
    }
}
