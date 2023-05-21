using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceItribitavel
{
    public class ContaCorrete 
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public double CalculaImposto()
        {
            Saldo = Saldo - (5 / 100);
            return Saldo;

        }

       
        
    }

    
}

