using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3;
            
            float media;
            

            Console.Write("Insira o 1º valor: ");
            n1 = float.Parse(Console.ReadLine());

            Console.Write("Insira o 2º valor: ");
            n2 = float.Parse(Console.ReadLine());

            Console.Write("Insira o 3º valor: ");
            n3 = float.Parse(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;

            Console.Write("A média desses valores é: " + media + "\n");

            








            Console.ReadKey();












        }
    }
}
