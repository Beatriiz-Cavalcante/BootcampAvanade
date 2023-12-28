using ExemploExplorando.models;

//Primeira parte só com a classe pessoa

//Pessoa p1 = new Pessoa();
//p1.Nome = "Beatriz";
//p1.Sobrenome = "Menezes";
//p1.Idade = 22;
//p1.Apresentar();

//Segunda parte adicionando a classe cursp

Pessoa p1 = new Pessoa("Beatriz", "Menezes"); //para instanciar
p1.Nome = "Beatriz";
p1.Sobrenome = "Menezes";
//p1.Idade = 22;
//p1.Apresentar();

Pessoa p2 = new Pessoa();
p2.Nome = "Clara";
p2.Sobrenome = "Cavalcante";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

//Formatação de valores monetários

Console.WriteLine("\n\nFormatação de valores monetários\n\n");

decimal ValorMonetario = 82.40M;
Console.WriteLine($"{ValorMonetario:C}");