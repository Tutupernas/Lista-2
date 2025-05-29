using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;


            Console.WriteLine("Digite seu peso");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua altura");
            altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);

            if (imc < 20)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc <= 20 && imc < 25)
            {

                Console.WriteLine("Peso ideal");
            }
            else
            {

                Console.WriteLine("Acima do peso");
            }

            Console.WriteLine(imc);
        }
    }
}
