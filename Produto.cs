using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Produto
    {
        private string _nome;
        public double _preco;
        private int _quantidade;

        public Produto()
        {
            _quantidade = 10;
        }

        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            _preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome // Properties
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        {
            get { return _preco; }
            set
            {
                _preco = value;
            }
        }

        public int Quantidade
        {
            get { return _quantidade; }

        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }

        }

        public double GetPreco()
        {
            return _preco;
        }

        public void setPreco(double preco)
        {
            _preco = preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantity)
        {
            _quantidade += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            _quantidade -= quantity;
        }

        public override string ToString()
        {
            return $"{_nome}, R${_preco}, {_quantidade} unidades Total: R${ValorTotalEmEstoque()}";
        }

    }
}
