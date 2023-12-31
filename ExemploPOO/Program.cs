﻿using ExemploPOO.Models;
using ExemploPOO.interfaces;

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

 //Herança

 Aluno a1 = new Aluno();
 a1.Nome = "Clabia";
 a1.Idade = 35;
 a1.Nota = 10;
 a1.Apresentar();

Professor pr1 = new Professor();
pr1.Nome = "Lucia";
pr1.Idade = 58;
pr1.Salario = 1000M;
pr1.Apresentar();


//Classe abstratas
Console.WriteLine("\n\nClasses abstratas\n\n");
Corrente c = new Corrente();
c.Creditar(500);
c.ExibirSaldo();

//Classe Object
Console.WriteLine("\n\nClasses Object\n\n");
Computador pc = new Computador();
Console.WriteLine(c.ToString());

//Interfaces
Console.WriteLine("\n\nInterfaces\n\n");
ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3, 9));