using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Troco_de_Compra
{
    internal class Program
    {
        static void Main(string[] args)
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
            
            Console.ReadKey();








        }
    }
}
