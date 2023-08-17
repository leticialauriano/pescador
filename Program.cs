using System;

/*
 Um pescador comprou um microcomputador para controlar o rendimento diário de seu trabalho. Toda vez que ele traz um peso de peixes maior que o estabelecido pelo regulamento de pesca do estado de São Paulo (50 quilos) deve pagar uma multa de R$ 4,00 por quilo excedente. Assim, faça um
programa que leia o peso de peixes e verifique se há excesso. Se houver, o programa também deve calcular o valor da multa que o pescador deverá pagar. No final, o programa deve imprimir o excesso e a multa paga pelo pescador.
 */

namespace Pescador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PESOMAXIMOPERMITIDOEMKG = 50;
            const double MULTAPORKGEXCEDIDO = 4;

            Console.WriteLine("--Programa Pescador--\n");

            Console.Write("Informe o peso pescado em Kg:");
            double pesoPescado = double.Parse(Console.ReadLine());

            double pesoExcedidoEmKg = 0;
            double multaPagaPeloPescador = 0;

            if (pesoPescado > PESOMAXIMOPERMITIDOEMKG)
            {
                pesoExcedidoEmKg = pesoPescado - PESOMAXIMOPERMITIDOEMKG;
                multaPagaPeloPescador = pesoExcedidoEmKg * MULTAPORKGEXCEDIDO;                
            }
                        
            Console.WriteLine($"Peso excedido: {pesoExcedidoEmKg:0.00} Kg.");
            Console.WriteLine($"Multa: R$ {multaPagaPeloPescador:0.00}.");

            Console.WriteLine("\n--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
