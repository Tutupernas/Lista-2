using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double basee;
            double altura;
            double area;

            Console.WriteLine("Digite um valor para a base do retângulo:");
            basee = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite agora o valor da altura desse retângulo:");
            altura = Convert.ToDouble(Console.ReadLine());

            area = basee * altura;

            if (area > 100)
            {

                Console.WriteLine("\r\nA área do terreno é de: {0} \r\n \r\nTerreno Grande!", area);

            }
            else if (area > 0 && area <= 100)
            {

                Console.WriteLine("A área do terreno é de: {0}", area);

            }
            else {
                Console.WriteLine("Número Inválido.");
            
            }
        }
    }
}
