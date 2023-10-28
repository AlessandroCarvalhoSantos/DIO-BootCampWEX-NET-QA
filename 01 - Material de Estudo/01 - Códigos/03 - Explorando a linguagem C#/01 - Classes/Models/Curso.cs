namespace Models;
public class Curso
{
    public string Nome { get; set; }
    public List<Pesssoa> Alunos { get; set; }

    public void AdicionarAluno(Pesssoa aluno)
    {
        Alunos.Add(aluno);
    }

    public int ObterQuantidadeDeAlunosMatriculados()
    {
        return Alunos.Count();
    }

    public bool RemoverAluno(Pesssoa pesssoa)
    {
        return Alunos.Remove(pesssoa);
    }

    public void ListarAlunos()
    {
        Console.WriteLine($"Alunos do curso de: {Nome}");

        foreach (var item in Alunos)
        {
            Console.WriteLine($"Nome: {item.NomeCompleto}");
        }
    }
}
