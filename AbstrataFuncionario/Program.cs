// Main();
using AbstrataFuncionario;

Assalariado a1 = new Assalariado(1,"Caio", 1000);

Assalariado a2 = new Assalariado(2,"Benda", 1000);
Comissionado c1 = new Comissionado(3,"Leo", 1000, 0.5);
Comissionado c2 = new Comissionado(4,"Theo", 1000, 0.6);
Dependente dd = new Dependente(2,"Cesar",15);
Dependente ddd = new Dependente(3,"Tina",23);
Dependente dddd = new Dependente(4, "Lina",16);
a1.AdicionarDependente(dddd);
a1.AdicionarDependente(ddd);

int x =0;
x =  a1.CalcularTotalDep();
a1.Listar();
Console.WriteLine(a1.Nome+" tem "+x+" filhos");
a1.RemoverDependente(3);
x =  a1.CalcularTotalDep();
System.Console.WriteLine();
a1.Listar();
c1.AdicionarDependente(dddd);
c1.AdicionarDependente(ddd);
c1.AdicionarDependente(dd);
Console.WriteLine(a1.Nome+" tem "+x+" filhos");


/* a1.Mostrar();
Console.WriteLine("novo salario:" + a1.CalcularSalario(30));
a2.Mostrar();
Console.WriteLine("novo salario:" + a2.CalcularSalario(30));
c1.Mostrar();
c1.CalcularSalario(25);
c2.Mostrar();
c2.CalcularSalario(22); */

Departamento d1 = new Departamento(1,"Ti");
d1.Admitir(a1);
d1.Admitir(c1);

Departamento d2 = new Departamento(1,"RH");
d2.Admitir(a2);
d2.Admitir(c2);

d1.VisualizarFuncionario();
d2.VisualizarFuncionario();

d2.DemitirFuncionario(2);
d2.VisualizarFuncionario();

Console.WriteLine($" Total da Folha do departamento {d1.Descricao}  {d1.CalcularFolha(30):C}");

Console.WriteLine($"Total da Folha do departamento {d2.Descricao}  {d2.CalcularFolha(30):C}");
d1.CalcularTotalporDep();
d2.CalcularTotalporDep();