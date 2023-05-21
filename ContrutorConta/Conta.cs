using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContrutorConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public static int Contador{get; set;}

        public Conta(int numero, string titular,double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            Contador = Contador + 1;
        }
        public Conta() //construtor padrão
        {
           
            //local da logica
             Contador = Contador + 1;
        }
        static Conta() //somente uma atributo estatico
        {
            Contador = 23;
        }
        public Conta(int numero)
        {
             Numero = numero;
             Contador = Contador + 1;
        }


        public void Mostrar()
        {
            Console.WriteLine($"Número: {Numero} \tTitular: {Titular} \tSaldo {Saldo:C}");
            ClasseEstatica.MostrarFrase();//exemplo de chamada de métado de uma classe estatíca
        }
    }
}
