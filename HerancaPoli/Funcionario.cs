using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaPoli
{
    public   class Funcionario
    {
        protected int codigo;
        
        protected string nome;
        
        protected double salario;
       
        public Funcionario( int codigo, string nome,double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }
        public void Visualizar()
        {
           Console.WriteLine("\n" + "Codigo:" + Codigo + "\tNome:" +  Nome + "\tSalario R$:" + Salario);
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
         public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public virtual double CalcularSalario()
        {
            return Salario = Salario * 44 / 26;
        }





        
    }
    
}

