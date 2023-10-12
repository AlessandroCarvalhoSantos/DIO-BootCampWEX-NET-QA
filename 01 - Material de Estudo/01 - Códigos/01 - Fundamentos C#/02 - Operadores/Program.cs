using Models;

public class Program
{
    public static void Main(string[] args)
    {
        //Operadores de atribuição

        // Atribuição Simples
        int x = 10;

        // Atribuição com Adição
        int y = 5;
        y += 3; // Agora y é 8

        // Atribuição com Subtração
        int z = 10;
        z -= 3; // Agora z é 7

        // Atribuição com Multiplicação
        int a = 2;
        a *= 4; // Agora a é 8

        // Atribuição com Divisão
        int b = 12;
        b /= 3; // Agora b é 4

        // Atribuição com Resto
        int c = 13;
        c %= 5; // Agora c é 3


        Console.WriteLine("x: " + x);
        Console.WriteLine("y: " + y);
        Console.WriteLine("z: " + z);
        Console.WriteLine("a: " + a);
        Console.WriteLine("b: " + b);
        Console.WriteLine("c: " + c);


        //convertando valores
        
        int inteiro = 42;
        double pontoFlutuante = inteiro; // Conversão implícita
        double pontoFlutuante3 = 3.14;
        int inteiro2 = (int)pontoFlutuante; // Conversão explícita
        string texto = "42";
        int inteiro3 = Convert.ToInt32(texto); // Usando Convert
        string texto1 = "3.14";
        double pontoFlutuante4 = double.Parse(texto); // Usando Parse

        string texto5 = "não é um número";
        try
        {
            int inteiro4 = int.Parse(texto);
            Console.WriteLine("A conversão foi bem-sucedida.");
        }
        catch (FormatException)
        {
            Console.WriteLine("A string não está em um formato válido para a conversão.");
        }

        string texto6 = "42";
        int inteiro6 = Convert.ToInt32(texto);

        int inteiro7 = Convert.ToInt32("42");
        long longo = Convert.ToInt64("1234567890");

        double pontoFlutuante8 = Convert.ToDouble("3.14");
        float pontoFlutuanteSimples = Convert.ToSingle("3.14");

        bool booleano = Convert.ToBoolean("true");

        char caractere = Convert.ToChar("A");

        try
        {
            int inteiro9 = Convert.ToInt32("não é um número");
            Console.WriteLine("A conversão foi bem-sucedida.");
        }
        catch (FormatException)
        {
            Console.WriteLine("A string não está em um formato válido para a conversão.");
        }

      
        int inteiroa = Convert.ToInt32(null);
        Console.WriteLine(inteiroa);

        int numero = 42;
        string texto42 = numero.ToString(); // 'texto' agora contém "42"


        //Conversão implícita
        short curto = 32000;
        int inteirob = curto; // Conversão implícita de short para int

        int inteiroc = 42;
        double pontoFlutuantec = inteiroc; // Conversão implícita de int para double

        //Procedencia

        int resultado = 10 + 5 * 2; // Multiplicação tem maior precedência que a adição

        Console.WriteLine("Resultado: " + resultado); // Deve imprimir "20"
    
        //Utilizando o try parse

        string g = "15-";

        int.TryParse(g, out int num); //Retorna true ou false.


        //Entendendo od IF
        if (true)
        {
            // Código a ser executado se a condição for verdadeira
        }
        else
        {
            // Código a ser executado se a condição for falsa
        }

        int num1 = 10;

        if (num1 > 5)
        {
            Console.WriteLine("O número é maior que 5");
        }
        else
        {
            Console.WriteLine("O número é menor ou igual a 5");
        }

        int idade = 20;

        if (idade < 18)
        {
            Console.WriteLine("Menor de idade");
        }
        else if (idade >= 18 && idade < 65)
        {
            Console.WriteLine("Adulto");
        }
        else
        {
            Console.WriteLine("Idoso");
        }


        //If aninhados
        int nota = 75;

        if (nota >= 90)
        {
            Console.WriteLine("A nota é A");
        }
        else if (nota >= 80)
        {
            Console.WriteLine("A nota é B");
        }
        else if (nota >= 70)
        {
            Console.WriteLine("A nota é C");
        }
        else if (nota >= 60)
        {
            Console.WriteLine("A nota é D");
        }
        else
        {
            Console.WriteLine("A nota é F");
        }


        //switch case
        int diaDaSemana = 3;

        switch (diaDaSemana)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;
            case 2:
                Console.WriteLine("Segunda-feira");
                break;
            case 3:
                Console.WriteLine("Terça-feira");
                break;
            case 4:
                Console.WriteLine("Quarta-feira");
                break;
            case 5:
                Console.WriteLine("Quinta-feira");
                break;
            case 6:
                Console.WriteLine("Sexta-feira");
                break;
            case 7:
                Console.WriteLine("Sábado");
                break;
            default:
                Console.WriteLine("Valor inválido");
                break;
        }

        string vogal = "a";

        switch (vogal)
        {
            case "a":
            case "e":
            case "i":
            case "o":  
            case "u":
                Console.WriteLine("Vogais");
            break;
            default:
                Console.WriteLine("Valor inválido");
            break;
        }

        //Operadores lógicos

        bool t = true;
        bool j = false;

        bool resultadoE = t && j; // Retorna false porque a é true e b é false
        bool resultadoOU = t || j; // Retorna true porque a é true
        bool resultadoNaoA = !t; // Retorna false porque a é true
        bool resultadoNaoB = !j; // Retorna true porque b é false


        int idade1 = 16;
        bool possuiPermissao = false;

        if (idade1 >= 18 || possuiPermissao)
        {
            Console.WriteLine("Acesso permitido");
        }
        else
        {
            Console.WriteLine("Acesso negado");
        }

        bool expressao1 = true;
        bool expressao2 = true;

        if (expressao1 && expressao2)
        {
            Console.WriteLine("Ambas as expressões são verdadeiras");
        }
        else
        {
            Console.WriteLine("Pelo menos uma das expressões é falsa");
        }

        bool expressao = true;

        if (!expressao)
        {
            Console.WriteLine("A expressão é falsa");
        }
        else
        {
            Console.WriteLine("A expressão é verdadeira");
        }

    }
}