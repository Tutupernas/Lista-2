using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ladoa, ladob, ladoc;

            Console.WriteLine("Digite o valor do lado A: ");
            ladoa = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado B: ");
            ladob = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado C: ");
            ladoc = double.Parse(Console.ReadLine());

            if (ladoa + ladob > ladoc || ladoa + ladoc > ladob || ladob + ladoc > ladoa)
            {

                Console.WriteLine("Os lados formam um triângulo.");

                if (ladoa == ladob && ladob == ladoc)
                {

                    Console.WriteLine("O triângulo é equilátero.");

                }
                else if (ladoa != ladob && ladoc != ladoa && ladoc != ladob)
                {

                    Console.WriteLine("O triângulo é escaleno.");

                }
                else
                {

                    Console.WriteLine("O triângulo é isósceles.");
                }
            }
            else
            {

                Console.WriteLine("Os lados não formam um triângulo.");
            }
        }
    }
}
