using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.Clear();
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n");
Console.Write("Digite o preço inicial: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.Write("\nAgora digite o preço por hora: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("====== DIO Estacionamento ======");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    Console.WriteLine("================================");
    Console.Write("Digite a sua opção: ");
    
    switch (Console.ReadLine())
    {
        case "1":
            Console.Clear();
            es.AdicionarVeiculo();
            break;

        case "2":
            Console.Clear();
            es.RemoverVeiculo();
            break;

        case "3":
            Console.Clear();
            es.ListarVeiculos();
            break;

        case "4":
            Console.Clear();
            exibirMenu = false;
            break;

        default:
            Console.Clear();
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
