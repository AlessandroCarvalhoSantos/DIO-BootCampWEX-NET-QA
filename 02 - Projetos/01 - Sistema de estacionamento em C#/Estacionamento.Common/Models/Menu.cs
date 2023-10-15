namespace Estacionamento.Common.Models;

public class Menu
{
    private EstacionamentoVeicular Estacionamento {get;set;}

    public Menu(EstacionamentoVeicular estacionamento)
    {
        Estacionamento = estacionamento;
    }

    public void InicializeMenu()
    {
        string option = string.Empty;

        while(option != "5")
        {
            DrawMenu();
            ViewOptions();
            option = Console.ReadLine();
            ExecuteOptions(option);
        };

    }

    public void ExecuteOptions(string option)
    {

        switch (option)
        {
            case "1":
                DrawMenu();
                PrintHeader("Configuração de valores iniciais");
                Console.SetCursorPosition(4,6);
                Estacionamento.ConfigurarValores();
            break;

            case "2":
                DrawMenu();
                PrintHeader("Adicionado os veículos no estacionamento");
                Console.SetCursorPosition(4,6);
                Estacionamento.AdicionarVeiculo();
            break;

            case "3":
                DrawMenu();
                PrintHeader("Removendo os veículos no estacionamento");
                Console.SetCursorPosition(4,6);
                Estacionamento.RemoverVeiculo();
            break;

            case "4":
                DrawMenu();
                PrintHeader("Listas de veículos estacionados");
                Estacionamento.ListarVeiculos();
            break;
            case "5":
                DrawMenu();
                ViewExit();
                Console.ReadKey();
            break;

            default:
                Console.WriteLine("Opção inválida");
            break;
        }        
    }

    public void DrawMenu()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;

        Console.Clear();
        Console.Write("+");
        PrintCaracter(50, "-");
        Console.WriteLine("+");

        for(int i = 0; i<12; i++)
        {
            Console.Write("|");
            PrintCaracter(50, " ");
            Console.WriteLine("|");
        }

        Console.Write("+");
        PrintCaracter(50, "-");
        Console.WriteLine("+"); 
    }
    private void PrintHeader(string title)
    {
        Console.SetCursorPosition(4,1);
        Console.WriteLine(title);
        Console.SetCursorPosition(1,2);
        PrintCaracter(50, "-");
        Console.SetCursorPosition(7,3);
        Console.WriteLine($"Entrada: {Estacionamento.PrecoInicial.ToString("F2")}  |  Preço por hora: {Estacionamento.PrecoPorHora.ToString("F2")}");
        Console.SetCursorPosition(1,4);
        PrintCaracter(50, "-");
    }
    public void ViewOptions()
    {

        PrintHeader("Seja bem vindo ao sistema de estacionamento!");

        Console.SetCursorPosition(3,5);
        Console.WriteLine("01 - Configurar");
        Console.SetCursorPosition(3,6);
        Console.WriteLine("02 - Cadastrar");
        Console.SetCursorPosition(3,7);
        Console.WriteLine("03 - Remover");
        Console.SetCursorPosition(3,8);
        Console.WriteLine("04 - Listar");
        Console.SetCursorPosition(3,9);
        Console.WriteLine("05 - Encerrar");
        Console.SetCursorPosition(3,10);
        Console.Write("Opção: ");
    }
    
    public void ViewExit()
    {

        Console.SetCursorPosition(13,1);
        Console.WriteLine("Sistema de Estacionamento");
        Console.SetCursorPosition(1,2);
        PrintCaracter(50, "-");
        Console.SetCursorPosition(7,7);
        Console.WriteLine($"Obrigado por utilizar nosso sistema!!!");
        Console.SetCursorPosition(0,14);

    
    }
    private void PrintCaracter(int qtd, string item)
    {
        for(int i = 0; i<qtd; i++)
        {
            Console.Write(item);
        }
    }
}