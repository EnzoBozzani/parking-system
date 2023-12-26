using desafio_estacionamento.Models;

Estacionamento estacionamento = new Estacionamento();
Console.WriteLine("Seja bem vindo ao estacionamento! ");
Console.WriteLine("Digite a taxa inicial: ");
bool success = int.TryParse(Console.ReadLine(), out int initialRate);
while (!success)
{
    Console.WriteLine("VALOR INVÁLIDO!\nDigite o preço inicial: ");
    success = int.TryParse(Console.ReadLine(), out initialRate);
}

Console.WriteLine("\nDigite a taxa por hora: ");
success = int.TryParse(Console.ReadLine(), out int hourRate);
while (!success)
{
    Console.WriteLine("VALOR INVÁLIDO!\nDigite a taxa por hora: ");
    success = int.TryParse(Console.ReadLine(), out hourRate);
}

string option = "";

while (option != "4")
{
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar Veículos");
    Console.WriteLine("4 - Encerrar");
    option = Console.ReadLine();
    switch (option)
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;
        case "2":
            estacionamento.RemoverVeiculo(initialRate, hourRate);
            break;
        case "3":
            estacionamento.ListarVeiculos();
            break;
        case "4":
            Console.WriteLine("Obrigado por utilizar!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Digite uma opcão válida!");
            break;
    }
}