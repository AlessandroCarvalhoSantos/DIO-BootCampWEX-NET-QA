namespace Models;


public class Calculadora
{
    public void Somar(int x, int y)
    {
        Console.WriteLine($"{x} + {y} = {x+y}");
    }

    public void Subtrair(int x, int y)
    {
        Console.WriteLine($"{x} - {y} = {x-y}");
    }

    public void Multiplicar(int x, int y)
    {
        Console.WriteLine($"{x} * {y} = {x*y}");
    }

    public void Dividir(int x, int y)
    {
        Console.WriteLine($"{x} / {y} = {x/y}");
    }

    public void Potencia(int x, int y)
    {
        double potencia = Math.Pow(x,y); //numero e depois o expoente
        Console.WriteLine($"{x} ^ {y} = {potencia}");
    }

    public void RaizQuadrada(int x)
    {
        double raiz = Math.Sqrt(x); 
        Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
    }

    public void Seno(double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        double seno = Math.Sin(angulo); 

        Console.WriteLine($"Seno de {angulo} = {Math.Round(seno,4)}");
    }

    public void CoSeno(double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        double coseno = Math.Cos(angulo); 

        Console.WriteLine($"Seno de {angulo} = {Math.Round(coseno,4)}");
    }

    public void Tagente(double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        double tagente = Math.Cos(angulo); 

        Console.WriteLine($"Seno de {angulo} = {Math.Round(tagente,4)}");
    }

}