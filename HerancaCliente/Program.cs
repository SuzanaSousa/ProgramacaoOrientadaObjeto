// Metédo main()
using HerancaCliente;

Cliente c = new Cliente();
c.Codigo = 1;
c.Nome = "Bia";
c.Endereco = "Rua Paulo Sebastião 23";
c.Visualizar();
ClienteFisico cf = new ClienteFisico();
cf.Codigo = 1;
cf.Nome = "Bia";
cf.Endereco = "Rua Paulo Sebastião 23";
cf.Rg = 23;
cf.Cpf = 233;
cf.Visualizar();
ClienteFisico cf2 = new ClienteFisico(23,"Luna", "Rua do Rosas", 34,344);

ClienteJuridico cj = new ClienteJuridico();
cj.Codigo = 3;
cj.Nome = "Lia";
cj.Endereco = "Rua Paulo Sebastião 44";
cj.Cnpj = 23;
cj.Ie = 33;
cj.Visualizar();