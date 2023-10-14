using Models;

public class Program
{
    public static void Main(string[] args)
    {
        int numero = 5;
        int contador = 0;
        for (contador = 0; contador < 10; contador++)
        {
            Console.WriteLine($"{numero} * { contador } = {numero * contador}");
        }

        contador = 0;
        while (contador < 5)
        {
            Console.WriteLine($"{numero} * { contador } = {numero * contador}");
            contador++;
        }

        contador = 0;
        do
        {
            Console.WriteLine($"{numero} * { contador } = {numero * contador}");
            contador++;
        } while (contador< 5);

        int i = 0;
        for (i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                break; // Sai do loop quando i é igual a 5
            }
            Console.WriteLine(i);
        }

        for (i = 0; i < 5; i++)
        {
            if (i == 2)
            {
                continue; // Pula para a próxima iteração quando i é igual a 2
            }
            Console.WriteLine(i);
        }




        string opcao;
        bool exibirMenu = true;

        while (exibirMenu)
        {
            Console.Clear();
            Console.WriteLine("Digite sua opção:");
            Console.WriteLine("01 - Cadastrar clientes:");
            Console.WriteLine("02 - Buscar cliente:");
            Console.WriteLine("03 - Apagar cliente:");
            Console.WriteLine("04 - Encerrar:");
            
            opcao = Console.ReadLine();

            switch(opcao)
            {
                case "1":
                    Console.WriteLine("Cadastro de cliente");
                break;
                case "2":
                    Console.WriteLine("Busca de cliente");
                break;
                case "3":
                    Console.WriteLine("Apagar de cliente");
                break;
                 case "4":
                    Console.WriteLine("Encerrar");
                    exibirMenu= false;
                break;
                default:
                    Console.WriteLine("Opção inválida");
                break;
            }
        }

        Console.WriteLine("Nossa aplicação foi encerrada com sucessor");

    }
}