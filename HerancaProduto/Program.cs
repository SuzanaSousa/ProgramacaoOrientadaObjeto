// metodo main()
using HerancaProduto;

Produto p  = new Produto();
p.Codigo = 22222;
p.Nome = "Mause";
p.Preco = 1400;
p.Visualizar();
ProdutoPerecivel pp = new ProdutoPerecivel();
pp.Codigo = 22222;
pp.Nome = "leite";
pp.Preco = 1400;
pp.DataValidade = "12/05/2030";
pp.DataFabricacao = "12/05//2023";
pp.Lote = 1;
pp.Visualizar();
Console.WriteLine("////////////////////////////////////////////////////////////////////////");
ProdutoPerecivel pp1 = new ProdutoPerecivel(33333,"Feijão",1200,"12/03/2031", "12/05/2032",2);
pp1.Visualizar();
