using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        public double Preco { get; set; }

        public int Tamanho { get; set; }
    
        public Produto()
        {
            
        }
        public Produto( double preco, int tamanho)
        {
            Preco = preco;
            Tamanho = tamanho;
        }
        public void MostrarProduto()
        {   
            Console.WriteLine("---------------------Produto-----------------------");
            Console.WriteLine("Preço R$:" + Preco + "\tTamanho: " + Tamanho);
        }
    }    

}
