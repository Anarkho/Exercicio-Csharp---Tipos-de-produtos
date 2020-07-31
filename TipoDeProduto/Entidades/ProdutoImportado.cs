using System.Globalization;

namespace TipoDeProduto.Entidades
{
    class ProdutoImportado : Produto
    {
        public double TaxaImportacao { get; set; }

        public ProdutoImportado() { }

        public ProdutoImportado(string nome, double preco, double taxaImportacao) : base(nome, preco)
        {
            TaxaImportacao = taxaImportacao;
        }

        public double PrecoTotal()
        {
            return Preco + TaxaImportacao;
        }

        public sealed override string EtiquetadePreco()
        {
            return $"ETIQUETA DE PREÇOS\n" +
                $"{Nome} $ {PrecoTotal().ToString("f2", CultureInfo.InvariantCulture)}" + " (Taxa de Importação: " + TaxaImportacao.ToString("f2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
