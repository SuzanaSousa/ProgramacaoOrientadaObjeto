using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaPoli
{
    public class Mensalista : Funcionario
    {
        public int QtdHorasTrabalhadas;

        public Mensalista( int codigo, string nome,double salario, int qtdhorastrabalhadas): base(codigo,nome,salario)
        {
            QtdHorasTrabalhadas = qtdhorastrabalhadas;
        }

        public override double CalcularSalario()
        {
                return Salario = Salario /  36 * QtdHorasTrabalhadas ;   
        }
    }



}

