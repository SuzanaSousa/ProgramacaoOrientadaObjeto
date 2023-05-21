using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public class ClienteFisico : Cliente
    {
        public int Cpf { get; set; }

        public ClienteFisico(int codigo, string nome, int cpf) :
                         base (codigo, nome)
        {
            Cpf = cpf;
        }
        public override void Mostrar()
        {
            Console.WriteLine("\nCódigo:" + Codigo + "\tNome:" + Nome + "\tCPF:" + Cpf);
        }
    }
}

