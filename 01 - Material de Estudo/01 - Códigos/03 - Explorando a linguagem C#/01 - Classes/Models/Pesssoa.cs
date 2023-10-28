namespace Models;

public class Pesssoa
{
    public Pesssoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public Pesssoa()
    {
        Nome = "Sem nome";
        Sobrenome = "Sem sobrenone";
    }

    private string _nome;
    private int _idade;
    public string Sobrenome { get; set; }

    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
    public string Nome 
    { 
        get => _nome.ToUpper(); 
        
        set 
        {
            if(value == "") 
            {
                throw new ArgumentException("O nome não pode ser vazio"); 
		          
			}
            _nome = value; 
        } 
    }
    public int Idade
    { 
        get => _idade;
        set
        {
            if(value < 0)
            {
                throw new ArgumentException("A idade não pode ser menor que 0.");
            }
            _idade = value;
        }
    
    }



    public void Apresentar()
    {
        Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
    }
}
