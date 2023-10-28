

using Models;

Pesssoa p1 = new Pesssoa(nome: "Alessandro", sobrenome: "Carvalho");
Pesssoa p2 = new Pesssoa(sobrenome: "Carvalho",nome: "Alessandro");



Pesssoa p3 = new Pesssoa("Rogério","Carlos");


Curso curso = new Curso();
curso.Nome = "Inglês";
curso.Alunos = new List<Pesssoa>();

curso.AdicionarAluno(p1);
curso.AdicionarAluno(p2);

curso.ListarAlunos();


