// fução Main()
using PolimorfismoFuncionario;
Funcionario f = new Funcionario(2,"Funcionário", 1000);
Console.WriteLine($"\n {f.Nome} - Bonificação {f.CalcularBonificacao():C}");

Secretario s = new Secretario(2,"Secretário", 1000,11);
Console.WriteLine($" {s.Nome} - Bonificação {s.CalcularBonificacao():C} \n");

Gerente g = new Gerente (2, "Gerente", 1000);
Console.WriteLine($"{g.Nome} - Bonificação {g.CalcularBonificacao():C} \n");

Diretor d = new Diretor (2, "Diretor", 1000);
Console.WriteLine($"{d.Nome} - Bonificação {d.CalcularBonificacao():C} \n");