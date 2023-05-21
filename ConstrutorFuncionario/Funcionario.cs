using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorFuncionario
{
    public class Funcionario
    {
        public static int Codigo {get; set; }

        public string Nome {get; set; }

        public double Salario { get; set; }

       
        public static int Contador { get; set; }

        public double Reajuste { get; set; }

       
        //private static int ProximoCodigo = 100;
     


       public Funcionario( string nome, double salario )
       {
            Codigo ++;
            Nome = nome;
            Salario = salario;
            Contador ++;
       }
       public Funcionario()
       {    
           
           Contador ++;
           Codigo ++;
       }
       static Funcionario()
       {
          Codigo = 100;
         
        
       }
       public Funcionario( double salario)
       { 
        
          Salario = salario;
          Codigo ++;
          Contador ++;

        }
       
        
         public void  CalcularSalario(double percentual)
         {
                Reajuste = Salario * percentual / 100;
                Salario = Salario   + Reajuste;
               // Salario = Salario +(Salario*percentual)/100;
         }
        public void Mostrar()
        {
           Console.WriteLine($"Codigo: {Codigo} \tNome: {Nome} \tSalário: {Salario:C}");
        }
       
    }
}