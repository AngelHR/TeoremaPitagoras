using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int lado1, lado2;

            Console.WriteLine("Ingresa el lado 1:");
            lado1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el lado 2:");
            lado2 = int.Parse(Console.ReadLine());

            double r = Math.Sqrt((lado1 * lado1) + (lado2 * lado2));

            Console.WriteLine($"la Hipotenusa es igual a {r}");

            Console.ReadKey();

        }
    }
}
