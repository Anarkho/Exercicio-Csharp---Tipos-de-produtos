using TipoDeProduto.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace TipoDeProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();

            Console.Write("Entre com o numero de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("\nDados do Produto #" + i);
                Console.Write("Normal, Usado, Importado ( N / U / I): ");
                char resposta = char.Parse(Console.ReadLine());
                if (resposta == 'N' || resposta == 'n')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preco: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Produto(nome, preco));

                }
                else if (resposta == 'U' || resposta == 'u')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preco: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Data de fabricação (DD/MM/YYYY): ");
                    DateTime dataDeFabricacao = DateTime.Parse(Console.ReadLine());
                    lista.Add(new ProdutoUsado(nome, preco, dataDeFabricacao));
                }
                else if (resposta == 'I' || resposta == 'i')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preco: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Taxa de Importação: ");
                    double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new ProdutoImportado(nome, preco, taxa));
                }
            }

            foreach (Produto p in lista)
            {
                Console.WriteLine("");
                Console.WriteLine("#########################################################");
                Console.WriteLine(p.EtiquetadePreco());
                Console.WriteLine("#########################################################");
            }
        }
    }
}
