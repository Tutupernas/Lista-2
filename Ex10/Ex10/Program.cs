using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1;
            double p2;
            double media;

            Console.WriteLine("Digite a primeira nota: ");
            p1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            p2 = Convert.ToDouble(Console.ReadLine());

            media = ((p1 + 2 * p2) / 3) - 1e-6;

            if (media >= 5 && media <= 10)
            {

                Console.WriteLine("Aprovado com media: {0:F2}", media);

            }
            else if (media < 5 && media >= 0)
            {

                Console.WriteLine("Reprovado com media: {0:F2}", media);
            }
            else
            {
                Console.WriteLine("Média inválida ");
            }
        }
    }
}
