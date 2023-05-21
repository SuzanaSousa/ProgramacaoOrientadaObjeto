using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Cliente
    {
        private string v1;
        private int v2;
        private int v3;

        public string Nome { get; set; }

        public int Cpf { get; set; }

        public int Rg { get; set; }
         
        public Endereco End { get; set; }
 
        public Cliente(string nome, int cpf, int rg)

        {
            Nome = nome;
            Cpf =  cpf;
            Rg = rg;
           
        }
        public Cliente()
        {

        }

      

        public void Mostrar()
        {
            Console.WriteLine("Nome: " + Nome + "\tCpf: " + Cpf + "\tRg: " + Rg);
            End.MostrarEndereco();
        }
    }
}


