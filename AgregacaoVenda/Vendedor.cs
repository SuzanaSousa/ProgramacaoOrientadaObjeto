using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Vendedor
    {
        public string Nome { get; set; }

        public int Codigo { get; set; }

        public double Comissao { get; set; }

        public Vendedor()
        {
            
        }
        public Vendedor(string nome, int codigo, double comisao)
        {
            Nome = nome;
            Codigo = codigo;
            Comissao = comisao;
        }

        public void MostrarVendedor()
        {  
            Console.WriteLine("---------------------Vendedor-----------------------");
            Console.WriteLine("Nome: " + Nome + "\tCódigo:" + Codigo + "\tComissão R$: " + Comissao);
        }
       
    }
}

