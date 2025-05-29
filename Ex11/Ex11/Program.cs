using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1;
            double p2;


            Console.WriteLine("Digite a nota da P1: ");
            p1 = Convert.ToDouble(Console.ReadLine());

            p2 = (15 - p1) / 2;

            Console.WriteLine("A nota da P2 precisa ser: {0} para que a média seja 5", p2);
        }
    }
}
