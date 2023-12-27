using aula01.Models;
Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Beatriz";
pessoa1.Idade = 22;
pessoa1.Apresentar();

Calculadora calc = new Calculadora();

calc.Somar(15, 10);
calc.Subtrair(30, 15);
calc.Multiplicar(15, 2);
calc.Dividir(30, 2);
calc.Potencia(3, 3);