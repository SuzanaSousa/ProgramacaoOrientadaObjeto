// Main();
using InterfaceAutenticavel;

Gerente g = new Gerente();
g.Nome ="Caio";
g.Senha = 456;

Diretor dd = new Diretor();
dd.Nome = "Lia";
dd.Senha = 155;

Cliente cc = new Cliente();
cc.Nome = "Cliente Tina";
cc.Endereco = "Rua dois de Maio";
cc.Senha = 178;

///IAutenticavel ia = new IAutenticavel();//erro
IAutenticavel ia;
ia = g;
Console.WriteLine(g.Nome + " - " + ia.Autenticar(155));///validandp senha senha correta 456
    
ia = dd;
Console.WriteLine(dd.Nome + " - " + ia.Autenticar(155));

ia = cc;
Console.WriteLine(cc.Nome + " - " + ia.Autenticar(178));