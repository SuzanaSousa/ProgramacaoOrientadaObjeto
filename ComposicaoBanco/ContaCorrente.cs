using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class ContaCorrente
    {
    
        public int Numero { get; set; }

        public string NomeTitular { get; set; }

        public double  Saldo { get; set; }

        public String DataAbertura { get; set; }

        public String DataExtrato{ get; set; }

        public double Emprestimo {get; set; }
        public List<Banco> ListaContas { get; set; }
        public ContaCorrente()
        {

        }
        public ContaCorrente(int numero,string nometitular, double saldo, string dataabertura,
               String dataExtra)
        {
            Numero = numero;
            NomeTitular = nometitular;
            Saldo = saldo;
            DataAbertura = dataabertura;
            DataExtrato = dataExtra;
        }
        
        
        public void EntrarEspecial( )
        {   
           double limiteChequeEspecial = 1000; 
           double taxaJuros = 0.1;
           double valorChequeEspecial = limiteChequeEspecial * (1 + taxaJuros) - Saldo;
           Console.WriteLine("Nome do cliente:" + NomeTitular + 
           ". Entrou no cheque especial  com saldo  de R$:" + valorChequeEspecial +"\n");
           
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
             "\tSaldo R$:" + Saldo + "\tValor de deposito foi de R$:" +  valorDeposito);
        }
        public void  ListarClientes()
        {
            Console.WriteLine("Numero da Conta: " + Numero +"\tNome do Titular: " + NomeTitular +
             "\tSaldo R$: " + Saldo + "\tData de Abertura: " + DataAbertura +"\n");
        }
      
        public void GerarExtato()
        {
            Console.WriteLine("Numero da Conta: " + Numero +"\tNome do Titular: " + NomeTitular +
             "\tSaldo R$:" + Saldo +"\tData de Abertura: " + DataAbertura +"\t\nData do Extrato: " + DataExtrato +"\n");

        }

        
    }
    
}


    

