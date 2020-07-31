using System.Globalization;

namespace TipoDeProduto.Entidades
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto() { }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string EtiquetadePreco()
        {
            return $"ETIQUETA DE PREÇOS\n" +
                $"{Nome} $ {Preco.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
