using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Poupanca
    {
        public int Numero { get; set; }

        public string NomeTitular { get; set; }

        public double  Saldo { get; set; }

        public String DataAbertura { get; set; }

        
        public List<Banco> ListaContas { get; set; }
        public Poupanca()
        {

        }
        public Poupanca(int numero,string nometitular, double 
        saldo,string dataabertura)
        {
            Numero = numero;
            NomeTitular = nometitular;
            Saldo = saldo;
            DataAbertura = dataabertura;
            
        }  
        public void GerarRendimento(double Rendimento)
        {   
            
            Saldo = Saldo + (Saldo * Rendimento);
             Console.WriteLine("Numero da Conta: " + Numero +"\tNome do Titular: " + NomeTitular +
             "\tSaldo R$:" + Saldo + "\tValor do rendimento foi R$:" +  Rendimento);

        }
        public void Sacar( double valorSaque)
        {
             Saldo = Saldo - valorSaque;
             Console.WriteLine("Numero da Conta: " + Numero +"\tNome do Titular: " + NomeTitular +
             "\tSaldo R$:" + Saldo + "\tValor de saque do R$:" +  valorSaque);
        }
        public void Depositar(double valorDeposito )
        {   
            
            Saldo = Saldo + valorDeposito;
              Console.WriteLine("Numero da Conta: " + Numero +"\tNome do Titular: " + NomeTitular +
             "\tDeposito no valor de R$:" + valorDeposito);
        }
        public void  ListarClientes()
        {
            Console.WriteLine("Numero da Conta: " + Numero +"\tNome do Titular: " + NomeTitular +
             "\tSaldo R$:" + Saldo + "\tData de Abertura: " + DataAbertura);
        }

        
    }
    
}

