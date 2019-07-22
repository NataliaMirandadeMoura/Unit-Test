using System;

namespace Projeto
{
    public class Produto
    {

        public Produto(string nome, int quantidade, string descricao)
        {

            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("nome inválido");

            if (Quantidade < 3)
                throw new ArgumentException();

            if (string.IsNullOrEmpty(descricao))
                throw new ArgumentException();

            Nome = nome;
            Quantidade = quantidade;
            Descricao = descricao;
        }

        public string Nome { get; private set; }
        public int Quantidade { get; private set; }
        public string Descricao { get; private set; }
    }

}

