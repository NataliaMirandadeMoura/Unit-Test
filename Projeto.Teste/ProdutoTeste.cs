using Bogus;
using ExpectedObjects;
using Projeto.Teste._Builders;
using Projeto.Teste._util;
using System;
using Xunit;
using Xunit.Abstractions;


namespace Projeto.Teste
{
    public class ProdutoTeste : IDisposable
    {

        private readonly ITestOutputHelper _output;
        private readonly string _nome;
        private readonly int _quantidade;
        private readonly string _descricao;


        public ProdutoTeste(ITestOutputHelper output)
        {
            _nome = "geladeira";
            _quantidade = 5;
            _descricao = "descricao";

            var faker = new Faker();
            _nome = faker.Random.Word();
            _descricao = faker.Random.Word();

        }
        [Fact]
        public void DeveCriarProduto()
        {
            var produtoEsperado = new
            {
                Nome = _nome,
                Quantidade = _quantidade,
                Descricao = _descricao,
            };
            var produto = new Produto(produtoEsperado.Nome, produtoEsperado.Quantidade, produtoEsperado.Descricao);

            produtoEsperado.ToExpectedObject().ShouldMatch(produto);


        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void DeveCriarProdutoInvalido(string nomeInvalido)
        {

            Assert.Throws<ArgumentException>(() => ProdutoBuilder.Novo().ComNome(nomeInvalido)
                .Build()).ComMensagem("nome inválido");

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]

        public void NaoDeveProdutoComQuantidadeMenorQue2(int quantidadeInvalida)
        {
            var produtoEsperado = new
            {
                Nome = "geladeira",
                Quantidade = (int)5,
                Descricao = "descricao",
            };
            Assert.Throws<ArgumentException>(() => new Produto(produtoEsperado.Nome,
               quantidadeInvalida, produtoEsperado.Descricao));
        }


        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void NaoDeveTerDescricaoInvalida(string descricaoInvalida)
        {
            var produtoEsperado = new
            {
                Nome = "geladeira",
                Quantidade = (int)5,
                Descricao = "descricao",
            };
            Assert.Throws<ArgumentException>(() => new Produto(produtoEsperado.Nome,
               produtoEsperado.Quantidade, descricaoInvalida));
        }





    }
}

