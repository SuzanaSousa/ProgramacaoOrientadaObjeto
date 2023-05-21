//função  Main() implicido
using AgregacaoConta;

Endereco end1 = new Endereco("Rua Bom Jesus", 33 ,"Vila Nova Patria", "São Sebastião");
Cliente cli = new  Cliente("Bia",333,33);

Conta c1 = new Conta();
c1.Numero = 1;
c1.Saldo = 300;
c1.Titular = cli;
c1.Titular.End = end1;
c1.Mostrar();

Conta c2 = new Conta();
c2.Numero = 2;
c2.Saldo = 500;
c2.Titular = new  Cliente();
c2.Titular.Nome = "Lia";
c2.Titular.Cpf = 3333333;
c2.Titular.Rg = 66;
c2.Titular.End = end1;
c2.Mostrar();


Cliente cli2 = new Cliente("Maria", 3333,33);
Conta c3 = new Conta();
c3.Numero = 3;
c3.Saldo = 300;
c3.Titular = cli2;
c3.Titular.End = end1;
c3.Mostrar();



