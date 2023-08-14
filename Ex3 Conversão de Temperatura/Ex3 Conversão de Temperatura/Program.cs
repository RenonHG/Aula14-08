using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Conversão_de_Temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float C, F;

            Console.Write("Insira a temperatura em ºC: ");
            C = float.Parse(Console.ReadLine());

            F = (C * 9 / 5) + 32;
            Console.Write("A temperatura de " + C + " ºC, é equivalente a: " + F + " ºF\n");

            Console.ReadKey();
        }
    }
}
