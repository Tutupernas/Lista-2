using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;
            double sexo = 0;


            Console.WriteLine("Digite seu peso");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua altura");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite seu sexo: 1 para feminino e 2 para masculino.");
            sexo = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);

            if (sexo == 1)
            {

                if (imc < 19)
                {
                    Console.WriteLine("Abaixo do peso");
                }
                else if (imc <= 19 && imc < 24)
                {

                    Console.WriteLine("Peso ideal");
                }
                else
                {

                    Console.WriteLine("Acima do peso");
                }

                Console.WriteLine(imc);

            }
            else if (sexo == 2)
            {

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
            else
            {
                Console.WriteLine("Sexo Inválido");
            }

        }
    }
}
