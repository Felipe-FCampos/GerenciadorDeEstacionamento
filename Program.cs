using teste_projeto_dotnet.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;
string? name = "";

Console.Clear();
Console.WriteLine("Seja bem-vindo ao Gerenciador de Estacionamento!\n\n" + 
"Primeiro preciso saber o seu nome, poderia digitá-lo, por gentileza?");

name = Console.ReadLine();

Console.WriteLine($"Perfeito, {name}!\n" + $"Seja muito bem-vindo, {name}, é um prazer termos você como nosso usuário!\n");

Console.WriteLine($"{name}, precisamos saber qual o preço inicial de seu estacionamento: ");

precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"{name}, digite agora o valor por hora: ");

precoPorHora = Convert.ToDecimal(Console.ReadLine());


Estacionamento garage = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool Menu = true;

while(Menu){

        decimal precoInicialAnterior = precoInicial;
        decimal precoPorHoraAnterior = precoPorHora;

        Console.Clear();
        Console.WriteLine($"Preço inicial: {precoInicial}\n");
        Console.WriteLine($"Preço por hora: {precoPorHora}\n");
        Console.WriteLine("Digite a opção desejada:");
        Console.WriteLine("1 - Cadastrar veículo");
        Console.WriteLine("2 - Remover veículo");
        Console.WriteLine("3 - Listar veículos");
        Console.WriteLine("4 - Alterar preço inicial");
        Console.WriteLine("5 - Alterar preço por hora");
        Console.WriteLine("6 - Encerrar");

        switch(Console.ReadLine()){
            case "1":
                garage.AdicionarVeiculo();
            break;

            case "2":
                garage.RemoverVeiculo();
            break;

            case "3":
                garage.ListarVeiculos();
            break;

            case "4":
                Console.WriteLine("Digite o novo valor do preço inicial: ");
                    precoInicial = Convert.ToDecimal(Console.ReadLine());  
                        garage.AlterarPrecoInicial(precoInicial, precoInicialAnterior);
            break;

            case "5":
                Console.WriteLine("Digite o novo valor do preço por hora: ");
                    precoPorHora = Convert.ToDecimal(Console.ReadLine());  
                        garage.AlterarPrecoPorHora(precoPorHora, precoPorHoraAnterior);
            break;

            case "6":
                Menu = false;
            break;

            default:
                Console.WriteLine("Opção inválida!");
            break;

        }
            Console.WriteLine("Pressione qualquer tecla para continuar!");
            Console.ReadLine();
}

Console.WriteLine("O programa se encerrou!");