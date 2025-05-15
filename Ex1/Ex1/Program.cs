using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1;
            double valor2;

            Console.WriteLine("Digite o primeiro valor");
            valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor diferente do primeiro");
            valor2 = double.Parse(Console.ReadLine());

            if (valor1 > valor2)
            {
                Console.WriteLine("O maior número digitado é: {0}", valor1);
            }
            else
            {
                Console.WriteLine("O maior número digitado é: {0}", valor2);
            } 
        }
    }
}
