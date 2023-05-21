using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Produto
    {
        protected int codigo ;

        protected string nome ;

        protected double preco;
        public Produto()
        {

        }
        public Produto(int codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;

        }
         public void Visualizar()
        {
           Console.WriteLine("\n" + "Codigo:" + Codigo + "\tNome:" +  Nome + "\tPreço R$:" + Preco);
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        
        
        
        
    }
}

