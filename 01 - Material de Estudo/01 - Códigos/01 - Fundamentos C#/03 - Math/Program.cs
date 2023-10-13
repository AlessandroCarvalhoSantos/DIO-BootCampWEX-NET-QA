using Models;

public class Program
{
    public static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();

        calc.Somar(2,2);
        calc.Subtrair(2,2);
        calc.Multiplicar(2,2);
        calc.Dividir(2,2);
        calc.RaizQuadrada(9);
        calc.Seno(3);
        calc.CoSeno(3);
        calc.Tagente(3);


        //Incremento e decremento
        int contador = 5;
        contador++; // Agora contador é 6

        int contador2 = 5;
        contador2--; // Agora contador é 4
        
    }
}