using AgregacaoVenda;

Produto p1 = new Produto();
p1.Preco = 300;
p1.Tamanho = 20;
Produto p2 = new Produto(90,7);
Produto p3  = new Produto(5000,5);
List<Produto> vetpd = new List<Produto>();
vetpd.Add(p1);
vetpd.Add(p2);
vetpd.Add(p3);

Venda v1 = new Venda();
v1.Cpo = new Comprador("Caio",12,6);
v1.Vdr = new Vendedor("Cesar",14,500);


v1.VetProduto = vetpd;
v1.MostrarVenda();

Venda v2 = new Venda();
v2.Cpo = new Comprador("Cintia",16,8);
v2.Vdr =  new Vendedor("Bia",16,700);

v2.VetProduto = vetpd;
v2.MostrarVenda();

Venda v3 = new Venda();
v3.Cpo = new Comprador("Bianca",16,2);
v3.Vdr =  new Vendedor("Lucas",19,500);

v3.VetProduto = vetpd;
v3.MostrarVenda();
