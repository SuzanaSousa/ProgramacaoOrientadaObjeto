using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        public Comprador Cpo { get; set; }

        public Vendedor Vdr { get; set; }

        public List<Produto> VetProduto { get; set; }

        public void MostrarVenda()
        {
           // Console.WriteLine("Comprador:" + Cpo.MostarComprador() + "\tVendedor: " + Vdr.MostrarVendedor);
             Cpo.MostarComprador();
             Vdr.MostrarVendedor();

            foreach (Produto v in VetProduto)
            {
                v.MostrarProduto();
            }
        }



    }
}

