using ExemploExplorando.models;
using System.Globalization;

//Primeira parte só com a classe pessoa

//Pessoa p1 = new Pessoa();
//p1.Nome = "Beatriz";
//p1.Sobrenome = "Menezes";
//p1.Idade = 22;
//p1.Apresentar();

//Segunda parte adicionando a classe curso

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


//Terceira parte (estudando exceções e coleções)
// se  usa o try catch para tratar
//vou colocar o nome do txt errado para mostrar a sintaxe do try catch
Console.WriteLine("\n\nExceções e coleções\n\n");

try
{
    string[] linhas = File.ReadAllLines("arquivos/arquivo_Leitura.txt");
    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally
{
    Console.WriteLine("\nChegou até aqui");
    //o finally é executado tanto após o try quanto do catch
}


//Usando o throw
 Console.WriteLine("\nUsando o throw\n");
new ExemploExcecao().Metodo1();

//Filas
Console.WriteLine("\nFilas\n");
Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(5);
fila.Enqueue(6);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
foreach(int item in fila)
{
    Console.WriteLine(item);
}

//Pilhas
Console.WriteLine("\nPilhas\n");

Stack<int> pilha = new Stack<int>();
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

//Dictionary
Console.WriteLine("\nDictionary\n");
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP","são paulo");
estados.Add("PE","Pernambuco");
estados.Add("BA","Bahia");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados["SP"] = "São Paulo";
Console.WriteLine("\n");
foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
