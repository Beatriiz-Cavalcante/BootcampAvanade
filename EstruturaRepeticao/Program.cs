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