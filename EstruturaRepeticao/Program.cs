string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1-Cadastrar Cliente;");
    Console.WriteLine("2-Buscar Cliente;");
    Console.WriteLine("3-Apagar Cliente;");
    Console.WriteLine("4-Encerrar;");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de Cliente");
            break;

        case "2":
            Console.WriteLine("Busca de Cliente");
            break;    

         case "3":
            Console.WriteLine("Apagar Cliente");
            break;
            
        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            //Environment.Exit(0) <-- Dessa forma o programa se encerra de uma vez fazendo com que o código pós while não seja compilado
            break;  

        default:
        Console.WriteLine("Opção inválida");
        break;
    }
}
Console.WriteLine("O programa se encerrou");

//Array (Atribuição de valores e acesso)

int[] arrayInteiros = new int[3];
arrayInteiros[0] = 15;
arrayInteiros[1] = 25;
arrayInteiros[2] = 30;

//acessando com for
for(int contador=0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição {contador} - {arrayInteiros[contador]}");
}

//acessando com foreach
foreach(int valor in arrayInteiros)
{
    Console.WriteLine(valor); 
}

//redimensionando array
//array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

//Listas (Atribuição de valores e acesso)

List<string> listaString = new List<string>();

listaString.Add("Koda");
listaString.Add("Cachorro");
listaString.Add("Irmão");

//acessando com for
for(int contador=0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição {contador} - {listaString[contador]}");
}

//acessando com foreach
foreach(int item in listaString)
{
    Console.WriteLine(item); 
}


