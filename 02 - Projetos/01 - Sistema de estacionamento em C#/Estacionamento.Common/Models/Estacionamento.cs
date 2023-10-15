namespace Estacionamento.Common.Models;

public class EstacionamentoVeicular
{
    public decimal PrecoInicial = 0;
    public decimal PrecoPorHora = 0;
    private List<string> Veiculos = new List<string>();

    public EstacionamentoVeicular(decimal precoInicial, decimal precoPorHora)
    {
        PrecoInicial = precoInicial;
        PrecoPorHora = precoPorHora;
    }

    public void ConfigurarValores()
    {
        Console.Write("Digite o valor da entrada:");
        decimal.TryParse(Console.ReadLine(), out decimal entrada);
        PrecoInicial = entrada;
        Console.SetCursorPosition(4,7);
        Console.Write("Digite o valor por hora: ");
        decimal.TryParse(Console.ReadLine(), out decimal precoHora);
        PrecoPorHora = precoHora;
    }

    public void AdicionarVeiculo()
    {        
        Console.Write("Digite a placa do veículo:");
        Veiculos.Add(Console.ReadLine());
    }

    public void RemoverVeiculo()
    {
        Console.Write("Digite a placa para remover:");
        string placa = Console.ReadLine();

        if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
        {
            Console.SetCursorPosition(4,7);
            Console.Write("Quantas horas que o veículo permaneceu:");
            int.TryParse(Console.ReadLine(), out int horas);
            decimal valorTotal = horas * PrecoPorHora + PrecoInicial; 

            Console.SetCursorPosition(4,8);
            Console.WriteLine($"O veículo {placa} foi removido.");
            Console.SetCursorPosition(4,9);
            Console.WriteLine($"Preço total foi de: R$ {valorTotal.ToString("F2")}");

            Veiculos.Remove(placa);
        }
        else
        {
            Console.SetCursorPosition(4,7);
            Console.WriteLine("Esse veículo não está estacionado aqui.");
        }
        Console.ReadKey();
    }

    public void ListarVeiculos()
    {   
        int i = 6;
        if (Veiculos.Any())
        {
            foreach (var item in Veiculos)
            {
                Console.SetCursorPosition(4,i++);
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.SetCursorPosition(4,6);
            Console.WriteLine("Não há veículos estacionados.");
        }
        Console.ReadKey();
    }
}

