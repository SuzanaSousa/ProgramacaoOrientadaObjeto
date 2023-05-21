using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Banco
    {
        
            public List<Poupanca> ListadeClientes {get; set; }
            
            public void ExibirClientes()
            {
                foreach(Poupanca p in ListadeClientes)
                        p.ListarClientes();
            } 
            public void ExibirSaque()
            {
                foreach(Poupanca p  in ListadeClientes)
                        p.Sacar(800);
            }
            public void  ExibirDeposito()
            {
                foreach(Poupanca p  in ListadeClientes)
                        p.Depositar(100);
            }
            public void ExibirRendimento()
            {
                foreach (Poupanca p in ListadeClientes)
                {
                        p.GerarRendimento(0.15 * 100);
                }
            }
            
            public List<ContaCorrente> ListadeCorrenteClientes {get; set; }
            
            public void ExibirClientesCorrente()
            {
                    foreach(ContaCorrente p in ListadeCorrenteClientes)
                            p.ListarClientes();
            } 
            public void ExibirExtrato()
            {
                foreach(ContaCorrente p in ListadeCorrenteClientes)
                     p.GerarExtato();
            }
             public void ExibirCorrenteSaque()
            {
                foreach(ContaCorrente p  in ListadeCorrenteClientes)
                        p.Sacar(800);
            }
            public void ExibirChequeEspecial()
            {
                foreach(ContaCorrente p in ListadeCorrenteClientes)
                     p.EntrarEspecial();
            }
    }
}

   