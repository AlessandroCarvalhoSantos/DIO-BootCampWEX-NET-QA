int[] arrayInteiro = new int[3];

arrayInteiro[0] = 72;
arrayInteiro[1] = 64;
arrayInteiro[2] = 25;


for(int i =0; i<arrayInteiro.Length; i++)
{
    Console.WriteLine($"Posição N°{i} : {arrayInteiro[i]}");
}


int[] numeros = new int[] { 1, 2, 3, 4, 5 };

foreach (int numero in numeros)
{
    Console.WriteLine(numero); // Isso imprimirá os números de 1 a 5 em linhas separadas.
}



Array.Resize(ref arrayInteiro,10);


for(int i =0; i<arrayInteiro.Length; i++)
{
    Console.WriteLine($"Posição N°{i} : {arrayInteiro[i]}");
}



int[] array = [1,2,3,4];

int[] arrayDobrado = new int[array.Length*2];

Array.Copy(array,arrayDobrado, array.Length);


//listas

List<string> listas = new List<string>();


listas.Add("SP");
listas.Add("BA");
listas.Add("RJ");


for(int i = 0; i<listas.Count; i++)
{
    Console.WriteLine(listas[i]);
}


foreach(string item  in listas)
{
    Console.WriteLine(item);
}

