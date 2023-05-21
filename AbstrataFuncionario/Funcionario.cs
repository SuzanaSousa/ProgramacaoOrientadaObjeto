using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{

    public abstract class Funcionario
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public double Salario { get; set; }

        public List<Dependente> VetDependente { get; set; }
        public abstract double CalcularSalario(int diasUteis);

        public virtual void Mostrar()
        {
            Console.WriteLine($"Código:{Codigo}\tNome: {Nome} \tSalário:C {Salario}");
        }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            VetDependente = new List<Dependente>();
        }
        public void AdicionarDependente(Dependente ll)
        {
            VetDependente.Add(ll);
        }
        public void Listar()
        {
            for (int i = 0; i < VetDependente.Count; i++)
            {    //fazendo uma generalizaçao
                Dependente d = VetDependente.ElementAt<Dependente>(i);//  pegar o elemento do indece 
                Console.WriteLine("Codigo:" + d.Codigo + "Nome:" + d.Nome + "Idade:" + d.Idade);
            }

        }

        public void RemoverDependente(int codigo)
        {
            foreach (Dependente dep in VetDependente)
            {

                if (dep.Codigo == codigo)
                {
                    if (dep.VerificarMaiorIdade())
                        VetDependente.Remove(dep);
                        return;
                }

            }
        }
        public int CalcularTotalDep ()
        {
            return VetDependente.Count;
        }
    }
}
