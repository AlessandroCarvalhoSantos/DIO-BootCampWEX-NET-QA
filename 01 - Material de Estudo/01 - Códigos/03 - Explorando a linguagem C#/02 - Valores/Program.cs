using Models;

using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

Pesssoa p1 = new Pesssoa(nome: "Alessandro", sobrenome: "Carvalho");
Pesssoa p2 = new Pesssoa(sobrenome: "Carvalho",nome: "Alessandro");



Pesssoa p3 = new Pesssoa("Rogério","Carlos");


Curso curso = new Curso();
curso.Nome = "Inglês";
curso.Alunos = new List<Pesssoa>();

curso.AdicionarAluno(p1);
curso.AdicionarAluno(p2);

curso.ListarAlunos();


//Trabalhando com valores monetários

decimal valorMonetario = 82.40M;

Console.WriteLine($"{valorMonetario:c5}");


valorMonetario.ToString();

decimal valor = 2.5M;
Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));


//Outros formatadores

decimal valorTeste =85.4M;

Console.WriteLine($"{valorTeste:C}");
Console.WriteLine($"{valorTeste:C2}");
Console.WriteLine($"{valorTeste:C3}");
Console.WriteLine($"{valorTeste:C4}");

Console.WriteLine($"{valorTeste:N}");
Console.WriteLine($"{valorTeste:N2}");
Console.WriteLine($"{valorTeste:N3}");
Console.WriteLine($"{valorTeste:N4}");

DateTime hoje = DateTime.Now;

Console.WriteLine($"{hoje:dd/mm/yyyy}");

//Representações de porcentagem

double porcentagem = 5.59D;

Console.WriteLine(porcentagem.ToString("P"));


int numero = 12345;
Console.WriteLine(numero.ToString("00-00-00"));


//Representação de datas

 // Obtendo a data e hora atual
DateTime agora = DateTime.Now;
Console.WriteLine("Data e Hora Atuais: " + agora);

// Criando uma nova data e hora
DateTime dataHoraPersonalizada = new DateTime(2023, 11, 5, 12, 30, 0);
Console.WriteLine("Data e Hora Personalizadas: " + dataHoraPersonalizada);

// Obtendo partes individuais da data e hora
int ano = agora.Year;
int mes = agora.Month;
int dia = agora.Day;
int hora = agora.Hour;
int minuto = agora.Minute;
int segundo = agora.Second;

Console.WriteLine($"Ano: {ano}, Mês: {mes}, Dia: {dia}, Hora: {hora}, Minuto: {minuto}, Segundo: {segundo}");

// Adicionando e subtraindo intervalos de tempo
DateTime dataNoFuturo = agora.AddHours(2);
DateTime dataNoPassado = agora.AddMonths(-1);

Console.WriteLine("Daqui a 2 horas: " + dataNoFuturo);
Console.WriteLine("Há 1 mês: " + dataNoPassado);

// Comparando datas
DateTime data1 = new DateTime(2023, 11, 5);
DateTime data2 = new DateTime(2023, 11, 6);

if (data1 < data2)
{
    Console.WriteLine("data1 é anterior a data2");
}
else if (data1 > data2)
{
    Console.WriteLine("data1 é posterior a data2");
}
else
{
    Console.WriteLine("data1 é igual a data2");
}

//formatação de datetime
string formatoPadrao = agora.ToString(); // Formato padrão (depende da configuração regional)
Console.WriteLine(formatoPadrao);

string dataCurta = agora.ToShortDateString(); // Exemplo: 05/11/2023
string dataLonga = agora.ToLongDateString(); // Exemplo: domingo, 5 de novembro de 2023
Console.WriteLine(dataCurta);
Console.WriteLine(dataLonga);

string horaCurta = agora.ToShortTimeString(); // Exemplo: 13:45
string horaLonga = agora.ToLongTimeString(); // Exemplo: 13:45:30
Console.WriteLine(horaCurta);
Console.WriteLine(horaLonga);

string formatoPersonalizado = agora.ToString("dd-MM-yyyy HH:mm:ss"); // Exemplo: 05-11-2023 13:45:30
Console.WriteLine(formatoPersonalizado);


DateTime dataHoje = DateTime.Now;

Console.WriteLine(dataHoje);
Console.WriteLine(dataHoje.ToString("yy/M/dd \'em\' HH:mm:s"));


Console.WriteLine(DateTime.Parse("2023 06 04"));
Console.WriteLine(DateTime.ParseExact("2023/06/01", "yyyy/MM/dd",null));

string dataString = "05/11/2023";
DateTime data;

if (DateTime.TryParseExact(dataString, "dd/MM/yyyy", null, DateTimeStyles.None, out data))
{
    Console.WriteLine("Conversão bem-sucedida: " + data);
}
else
{
    Console.WriteLine("String inválida para conversão.");
}



if (DateTime.TryParse(dataString, out data))
{
    Console.WriteLine("Conversão bem-sucedida: " + data);
}
else
{
    Console.WriteLine("String inválida para conversão.");
}


string dataStringHoje = "2023/05/11";

var valorFormatacao = DateTime.TryParseExact(dataStringHoje, "yyyy/MM/dd",CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataSaida);

if(valorFormatacao)
{
    Console.WriteLine($"Data válida {dataSaida}");
}
else
{
    Console.WriteLine($"Data inválida {dataSaida}");
}