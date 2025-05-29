using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double C;

            Console.WriteLine("Digite o valor de A: ");
            A = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            B = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            C = double.Parse(Console.ReadLine());

            if ((A + B > C) && (A + C > B) && (B + C > A))
            {

                Console.WriteLine("Os valores podem formar um triangulo");

                double cat1 = A, cat2 = B, hip = C;

                if (A > B && A > C)
                {

                    hip = A;
                    cat1 = B;
                    cat2 = C;
                }
                else if (B > A && B > C)
                {
                    hip = B;
                    cat1 = A;
                    cat2 = C;
                }
                else { }


                double hipotenusa = Math.Pow(hip, 2);
                double catetos = Math.Pow(cat1, 2) + Math.Pow(cat2, 2);

                if (hipotenusa == catetos)
                {

                    Console.WriteLine("O triangulo é retângulo");
                }
                else
                {



                    Console.WriteLine("O triangulo não é retângulo");
                }



            }
            else
            {

                Console.WriteLine("Os valores nao podem formar um triangulo");
            }

        }
    }
}
