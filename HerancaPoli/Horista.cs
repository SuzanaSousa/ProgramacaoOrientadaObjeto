using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaPoli
{
    
    public class Horista : Funcionario
    {
        
    
        public int QtdHorasSemanas;
        
       
        public Horista( int codigo, string nome,double salario, int qtdhorassemanas): base(codigo,nome,salario)
        {
            QtdHorasSemanas = qtdhorassemanas;

        }
         public override double CalcularSalario()
        {
                return Salario = Salario / 36 * QtdHorasSemanas ;  
        }
        
       
        
    }
}


