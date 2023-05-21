using ComposicaoBanco;
Console.WriteLine("\n........................CONTA POUPANÇA..................................\n");
Poupanca p1 =  new Poupanca (3333,"Samanta Sales",1000,"24/02/2023\n");
p1.ListarClientes();
Poupanca p2 =  new Poupanca (4444,"Sabrina Soller",1000,"26/02/2023\n");
p2.ListarClientes();
Poupanca p3 =  new Poupanca (5555,"Caio Cistian",1000,"29/02/2023\n");
p3.ListarClientes();
Banco b1 = new Banco();
b1.ListadeClientes = new List<Poupanca>();
b1.ListadeClientes.Add(p1); 
b1.ListadeClientes.Add(p2);
b1.ListadeClientes.Add(p3);
Console.WriteLine("\n...............................Saques.........................................\n");
b1.ExibirSaque();
Console.WriteLine("\n..............................Deposito..................................................");
b1.ExibirDeposito();
Console.WriteLine("\n..............................Rendimento..................................................");
b1.ExibirRendimento();
Console.WriteLine("\n......................Depois das Ultimas Atualizações................................\n");
b1.ExibirClientes(); 


Console.WriteLine("\n\n........................CONTA Corrente..................................\n");

ContaCorrente c1 =  new ContaCorrente (3333,"Cintia Sales",1000,"24/02/2023","31/03/2023");
c1.ListarClientes();
ContaCorrente c2 =  new ContaCorrente (4444,"Kadu Soller",1000,"26/02/2023","31/03/2023");
c2.ListarClientes();
ContaCorrente c3 =  new ContaCorrente (5555,"Cesar Cistian",1000,"29/02/2023","31/03/2023");
c3.ListarClientes();

Banco b2 = new Banco();
b2.ListadeCorrenteClientes = new List<ContaCorrente>();
b2.ListadeCorrenteClientes.Add(c1); 
b2.ListadeCorrenteClientes.Add(c2);
b2.ListadeCorrenteClientes.Add(c3);
Console.WriteLine("\n......................Extrato do mês de março................................\n");
b2.ExibirExtrato();
Console.WriteLine("\n...............................Saques.........................................\n");
b2.ExibirCorrenteSaque();
Console.WriteLine("\n...............................Cheque Especial.........................................\n");
b2.ExibirChequeEspecial();
Console.WriteLine("\n......................Depois das Ultimas Atualizações................................\n");
b2.ExibirClientesCorrente();