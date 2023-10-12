using Models;
using ModelsPessoa;

public class Program
{
    public static void Main(string[] args)
    {
        ModelsPessoa.Pessoa p1 = new ModelsPessoa.Pessoa();
        Models.Pessoa p2 = new Models.Pessoa();

        p2.Nome = "Alessandro";
        p2.Apresentar();

        //Quebras de linhas de código e texto de saída
        var item = "Quebra de linha "
        + "Quebra de linha 2";

        item = "Quebra de linha \n Quebra de linha 2";

        p2


        .Nome = "Alessandro";

        //Tipos de dados


        int numeroInteiro = 42;
        long numeroLongo = 1234567890L;
        short numeroCurto = 32000;
        byte meuByte = 255;

        float numeroPontoFlutuante = 3.14f;
        double numeroDuplo = 3.141592653589793;
        decimal numeroDecimal = 123.456m;

        bool eVerdadeiro = true;

        char meuChar = 'A';

        string meuTexto = "Olá, mundo!";


        uint numeroSemSinal = 4294967295U;
        ulong numeroSemSinalLongo = 18446744073709551615UL;
        ushort numeroSemSinalCurto = 65535;
        byte meuByteSemSinal = 255;

        object meuObjeto = 42;

        Console.WriteLine(numeroInteiro);
        Console.WriteLine(numeroLongo);
        Console.WriteLine(numeroCurto);
        Console.WriteLine(meuByte);

        Console.WriteLine(numeroPontoFlutuante);
        Console.WriteLine(numeroDuplo);
        Console.WriteLine(numeroDecimal);

        Console.WriteLine(eVerdadeiro);

        Console.WriteLine(meuChar);

        Console.WriteLine(meuTexto);

        Console.WriteLine(numeroSemSinal);
        Console.WriteLine(numeroSemSinalLongo);
        Console.WriteLine(numeroSemSinalCurto);
        Console.WriteLine(meuByteSemSinal);

        Console.WriteLine(meuObjeto);


        //Casas decimais 0 no final.
        double  teste1 = 1.80;
        decimal teste2 = 1.80M;

        Console.WriteLine(teste1); // 1.8
        Console.WriteLine(teste2); // 1.80

        Console.WriteLine(teste1.ToString("0.00")); //1.80
        //Aqui tivemos que adicionar um tratamento para printar a casa depois do 0

        DateTime dataAtual = DateTime.Now;
        Console.WriteLine(dataAtual);
        Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

        

    }
}