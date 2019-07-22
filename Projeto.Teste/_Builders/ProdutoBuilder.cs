using System;
using System.Collections.Generic;
using System.Text;
using static Projeto.Teste.ProdutoTeste;

namespace Projeto.Teste._Builders
{
    //Vai retornar ele mesmo
    //Assim posso criar diferentes representações


    public class ProdutoBuilder
    {
        private string _nome = "geladeira";
        private int _quantidade = 5;
        private string _descricao = "descricao";

  

        public static ProdutoBuilder Novo()
        {
            return new ProdutoBuilder();

        }

        public ProdutoBuilder ComNome(string nome)
        {
            _nome = nome;
             return this;
        }

        public ProdutoBuilder ComDescricao(string nome)
        {
            _nome = nome;
            return this;
        }


        public Produto Build()
        {
            return new Produto(_nome, _quantidade, _descricao);
        }
    }
}
