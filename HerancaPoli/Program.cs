// Método main()
using HerancaPoli;

Mensalista m = new Mensalista (3,"Thiago Costa",1500,30);
Console.WriteLine($"{m.Nome} - Salario {m.CalcularSalario():C} \n");


Horista h = new Horista (3,"Bianca Alcantara",1500, 44 );
Console.WriteLine($"{h.Nome} - Salario {h.CalcularSalario():C} \n");