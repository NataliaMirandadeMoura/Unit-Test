using System;
using Xunit;

namespace Projeto.Test
{
    public class ProdutoTest
    {
        [Fact]
        public void DeveCriarUmProduto()
        {
            string nome = "geladeira";
            int quantidade = 5;
            string descricao = "descricao";

            var produto = new Produto(nome, quantidade, descricao);

            Assert.Equal(nome, produto.Nome);
            Assert.Equal(quantidade, produto.Quantidade);
            Assert.Equal(descricao, produto.Descricao);
        }

        public class Produto
        {


            public Produto(string nome, int quantidade, string descricao)
            {
                Nome = nome;
                Quantidade = quantidade;
                Descricao = descricao;
            }

            public string Nome { get; private set; }
            public int Quantidade { get; private set; }
            public string Descricao { get; private set; }
        }
    }
}

   
