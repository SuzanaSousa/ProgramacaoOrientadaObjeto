//função Main () implicido
using AgregacaoContaVetor;

Conta c1 = new Conta();
c1.Numero = 3;
c1.Saldo = 3000;

Cliente cli1 = new Cliente("Lia",2222,22);
Cliente cli2 = new Cliente("Caio",4444,44);
Cliente cli3 = new Cliente ("Bob",5555,55);

c1.VetTitular = new List<Cliente>(); //primeiro estência para depois 
c1.VetTitular.Add(cli1);
c1.VetTitular.Add(cli2);
c1.VetTitular.Add(cli3);

foreach(Cliente c in c1.VetTitular)
    c.MostrarCliente();
