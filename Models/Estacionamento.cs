using System.Security.Cryptography.X509Certificates;

namespace teste_projeto_dotnet.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;

        private decimal precoPorHora = 0;

        private List<string> Veiculos = new List<string>();


        public Estacionamento(decimal precoInicial, decimal precoPorHora){
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo(){
            Console.WriteLine("Digite a placa do seu veículo ou se caso desejar voltar digite 0: ");
            string placa = Console.ReadLine() ?? string.Empty;
            if(placa == "0"){
                    Console.WriteLine("Voltando ao menu...\n");
            } else {
                if(Veiculos.Any(x => x.ToUpper() == placa.ToUpper())){
                    Console.WriteLine($"Veículo de placa {placa} já foi cadastrado, digite uma nova placa!");
                    
            } else {
                Veiculos.Add(placa);
                    Console.WriteLine($"O veículo de placa {placa} foi adicionado.");
            }   
            }
        }
        
        public void RemoverVeiculo(){
            
            Console.WriteLine("Qual veículo deseja remover?\n" + 
            "Digite a placa:\n" + 
            "Se não deseja remover algum veículo, digite 0: \n");

            if(Veiculos.Any()){
                Console.WriteLine("Veículos estacionados: ");

                foreach(string veiculo in Veiculos){
                    Console.WriteLine(veiculo);
                }
            } else {
                Console.WriteLine("Não há veículos estacionados!");
            }

            string placa = Console.ReadLine() ?? string.Empty;

            if(placa == "0"){
                Console.WriteLine("Voltando ao menu...\n");
            } else {
                if(Veiculos.Any(x => x.ToUpper() == placa.ToUpper())){

                Console.WriteLine("Digite o tempo que esse veículo ficou no estacionamento: ");
                string horas = Console.ReadLine() ?? string.Empty;
                int horasInteiras = Convert.ToInt32(horas);

                decimal calculo = precoInicial + precoPorHora * horasInteiras;
            
                decimal valorTotal = calculo;

                Veiculos.Remove(placa);

                Console.WriteLine($"Veículo de placa {placa} removido com sucesso, o valor a pagar é de R$ {valorTotal}.");

            } else {
                Console.WriteLine($"Veículo de placa {placa} não encontrado, verifique se digitou a placa correta!");
            }   
            }

        }

        public void ListarVeiculos(){
            if(Veiculos.Any()){
                Console.WriteLine("Veículos estacionados: ");

                foreach(string placa in Veiculos){
                    Console.WriteLine(placa);
                }
            } else {
                Console.WriteLine("Não há veículos estacionados!");
            }
        }

        public void AlterarPrecoInicial(decimal precoInicial, decimal precoInicialAnterior){
            this.precoInicial = precoInicial;
            Console.WriteLine($"O valor inicial foi alterado de R$ {precoInicialAnterior} para R$ {precoInicial}.");
        }

        public void AlterarPrecoPorHora(decimal precoPorHora, decimal precoPorHoraAnterior){
            this.precoPorHora = precoPorHora;
            Console.WriteLine($"O valor por hora foi alterado de R$ {precoPorHoraAnterior} para R$ {precoPorHora}.");
        }
    }
}