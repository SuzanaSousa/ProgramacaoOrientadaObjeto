using ConstrutorFuncionario;

Funcionario  f1 =  new Funcionario("ffff",74);
f1.Mostrar();
Console.WriteLine("-------------------Antes do reajuste--------------------\n");
f1.CalcularSalario(100);
Console.WriteLine("-------------------Depois do reajuste--------------------\n");
f1.Mostrar();

Funcionario f3 = new Funcionario("bruna",1500);
Console.WriteLine("-------------------Antes do reajuste--------------------\n");
f3.Mostrar();
Console.WriteLine("-------------------Depois do reajuste--------------------\n");
f3.CalcularSalario(100);
f3.Mostrar();

Funcionario  f2 =  new Funcionario("Lucas",5000);
Console.WriteLine("-------------------Antes do reajuste--------------------\n");
f2.Mostrar();
Console.WriteLine("-------------------Depois do reajuste--------------------\n");
f2.CalcularSalario(100);
f2.Mostrar();
System.Console.WriteLine(f2.Reajuste);

Console.WriteLine("-------------------Quantidade de funcionários------------\n");
Console.WriteLine("Qtd de Funcionario ? " + Funcionario.Contador + " \n");



