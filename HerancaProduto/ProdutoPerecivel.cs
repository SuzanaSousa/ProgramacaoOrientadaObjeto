using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class ProdutoPerecivel: Produto
    {
        /*protected string datavalidade;*/
        public string DataValidade { get; set; }
        /*protected string datafabricacao ;*/
        public string DataFabricacao { get; set; }
        /* protected int lote;*/
        public int Lote { get; set; }
        public ProdutoPerecivel()
        {
            
        }
        public ProdutoPerecivel(int codigo, string nome, double preco, string datafabricacao, string datavalidade,int lote):base( codigo, nome,preco)
        {
            DataFabricacao = datafabricacao;
            DataValidade = datavalidade;
            Lote = lote;
        }
        
       
        public void Visualizar()
        {   
            base.Visualizar();
            Console.WriteLine("Lote:" + Lote + "\tData Fabricação:" + DataFabricacao + "\tData Validade:"+ DataValidade + "\n");
        }
}   }  



