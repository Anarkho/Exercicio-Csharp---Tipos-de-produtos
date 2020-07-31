using System;
using System.Globalization;
namespace TipoDeProduto.Entidades
{
    class ProdutoUsado : Produto
    {
        public DateTime DataDeFabricacao { get; set; }

        public ProdutoUsado() { }

        public ProdutoUsado(string nome, double preco, DateTime dataDeFabricacao) : base(nome, preco)
        {
            DataDeFabricacao = dataDeFabricacao;
        }

        public sealed override string EtiquetadePreco()
        {
            return $"ETIQUETA DE PREÇOS\n" +
                $"{Nome} (usado) $ {Preco.ToString("f2", CultureInfo.InvariantCulture)} " + "(Data de Fabricação: " + DataDeFabricacao.ToString("dd/MM/yyy") + ")";
        }
    }


}
