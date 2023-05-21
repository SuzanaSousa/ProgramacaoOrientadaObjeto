using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Comprador
    {
        public string Nome { get; set; }

        public int Codigo { get; set; }
        public double Verba { get; set; }

        public Comprador()
        {
            
        }
        public Comprador(string nome, int codigo, double verba)
        {
            Nome = nome;
            Codigo = codigo;
            Verba = verba;
        }
        public void MostarComprador()
        {    
            Console.WriteLine("---------------------Comprador-----------------------");
            Console.WriteLine("Nome: " + Nome + "\tCodigo: " + Codigo + "\tVerba: " + Verba);
        }

    }

}

