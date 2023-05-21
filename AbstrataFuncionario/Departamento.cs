using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }

        public string Descricao { get; set; }

        public List<Funcionario> VetFuncionario { get; set; }

        public List<Dependente> VetDependente { get; set; }
        public Departamento(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
            VetFuncionario = new List<Funcionario>();
            VetDependente = new List<Dependente>();
        }

        public void Admitir(Funcionario f)
        {
            VetFuncionario.Add(f);
        }
        public void DemitirFuncionario(int codigo)
        {
            for (int i = 0; i < VetFuncionario.Count; i++)
            {    //fazendo uma generalizaçao
                Funcionario f = VetFuncionario.ElementAt<Funcionario>(i);                    //  pegar o elemento do indece      armazemado na variavel
                if (f.Codigo == codigo)
                    VetFuncionario.Remove(f);
            }
        }
        public void VisualizarFuncionario()
        {
            Console.WriteLine("\nDepartamento " + Descricao);
            for (int i = 0; i < VetFuncionario.Count; i++)
            {
                Funcionario f = VetFuncionario.ElementAt<Funcionario>(i);
                f.Mostrar();
            }


        }
        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;
            for (int i = 0; i < VetFuncionario.Count; i++)
            {
                Funcionario f = VetFuncionario.ElementAt<Funcionario>(i);
                folha = folha + f.CalcularSalario(diasUteis);
            }
            return folha;


        }
        public void CalcularTotalporDep()
        {
            for (int i = 0; i < VetFuncionario.Count; i++)
            {
                Funcionario f = VetFuncionario.ElementAt<Funcionario>(i);
                
                System.Console.WriteLine("Nome: "+f.Nome + "tem "+f.CalcularTotalDep()+"dependentes");
            }
        }



    }




}



