using ExemploPOO.Models;

//pessoa
Pessoa p1 = new Pessoa();
p1.Nome = "Beatriz";
p1.Idade = 22;

p1.Apresentar();

//contacorrente

ContaCorrente c1 = new ContaCorrente(123,1000);
 c1.ExibirSaldo();
 c1.Sacar(500); 
 c1.ExibirSaldo();