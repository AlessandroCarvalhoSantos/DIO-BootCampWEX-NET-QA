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

    }
}