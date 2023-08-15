using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3em1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu;

            Console.WriteLine("Menu: ");
            Console.WriteLine("1 - Média de três números");
            Console.WriteLine("2 - Troco de Compra");
            Console.WriteLine("3 - Conversão de Temperatura");
            Console.WriteLine("Escolha a opção: ");
            menu = int.Parse(Console.ReadLine());

            if (menu == 1)
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
            }

            else if (menu == 2)
            {
                float preco;
                float pago;
                float troco;

                Console.Write("Preço do produto: R$");
                preco = float.Parse(Console.ReadLine());
                //Console.WriteLine("O preço do produto é: R$" + preco);

                Console.Write("Valor pago pelo cliente: R$");
                pago = float.Parse(Console.ReadLine());

                if (pago < preco)
                {
                    Console.WriteLine("Desculpe, infelizmente você não possui o valor necessário para comprar esse produto");
                }
                else
                {
                    troco = pago - preco;
                    Console.WriteLine("Troco: R$" + troco);
                }
            }

            else
            {
                float C, F;

                Console.Write("Insira a temperatura em ºC: ");
                C = float.Parse(Console.ReadLine());

                F = (C * 9 / 5) + 32;
                Console.Write("A temperatura de " + C + " ºC, é equivalente a: " + F + " ºF\n");
            }

            Console.ReadKey();

        }
    }
}
