//função main()
using ContrutorConta;

Conta c1 = new Conta();
c1.Mostrar();

Conta c2 = new Conta(1);
c2.Mostrar();

Conta c3 = new Conta (23,"Suzana", 1000);
c3.Mostrar();

//Quantas intancias foram  realizadas //3
// OBS:construtor que instância
//implemente esta lógica 
//static so pode ser usado no estatico no pode ter paramentro.
//OBS: variavel de instância e o objeto
Console.WriteLine("Qtd de intâncias? " + Conta.Contador);



///classe estatica
//ClasseEstatica.MostrarFrase();exemplo de chamada de métado de uma classe estatíca