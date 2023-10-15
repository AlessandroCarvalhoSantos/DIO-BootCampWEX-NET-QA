using Estacionamento.Common.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 5;
decimal precoPorHora = 2;

EstacionamentoVeicular es = new EstacionamentoVeicular(precoInicial, precoPorHora);


Menu menu = new Menu(es);
menu.InicializeMenu();



