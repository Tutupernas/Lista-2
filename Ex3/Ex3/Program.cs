using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1;
            double valor2;
            double valor3;
            

            Console.WriteLine("Digite o primeiro valor:");
            valor1 = double.Parse(Console.ReadLine()) ;

            Console.WriteLine("Digite o segundo valor");
            valor2 = double.Parse(Console.ReadLine()) ;

            Console.WriteLine("Digite o terceiro valor");
            valor3 = double.Parse(Console.ReadLine());

            if (valor1 > valor2 && valor1 > valor3)
            {
                Console.WriteLine("O maior valor é: {0}", valor1);
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                Console.WriteLine("O maior valor é: {0}", valor2);
            }
            else if (valor3 > valor1 && valor3 > valor2)
            {
                Console.WriteLine("O maior valor é: {0}", valor3);
            }
            else if (valor1 == valor2 && valor1 > valor3)
            {
                Console.WriteLine("O maior valor é: {0}", valor1);

            }
            else if (valor2 == valor3 && valor2 > valor1)
            {
                Console.WriteLine("O maior valor é: {0}", valor2);

            }
            else {
                Console.WriteLine("O maior valor é: {0}", valor3);
            }
        }
    }
}
