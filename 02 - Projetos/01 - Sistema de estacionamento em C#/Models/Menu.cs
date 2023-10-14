namespace Models;

public class Menu
{
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
        ViewOptions();
    }

    private void PrintHeader(string title)
    {
        Console.SetCursorPosition(4,1);
        Console.WriteLine(title);
        Console.SetCursorPosition(1,2);
        PrintCaracter(50, "-");
    }
    public void ViewOptions()
    {

        PrintHeader("Seja bem vindo ao sistema de estacionamento!");

        Console.SetCursorPosition(3,4);
        Console.WriteLine("01 - Cadastrar");
        Console.SetCursorPosition(3,5);
        Console.WriteLine("02 - Remover");
        Console.SetCursorPosition(3,6);
        Console.WriteLine("03 - Listar");
        Console.SetCursorPosition(3,7);
        Console.WriteLine("04 - Encerrar");
        Console.SetCursorPosition(3,8);
        Console.Write("Opção: ");
    }

    private void PrintCaracter(int qtd, string item)
    {
        for(int i = 0; i<qtd; i++)
        {
            Console.Write(item);
        }
    }
}