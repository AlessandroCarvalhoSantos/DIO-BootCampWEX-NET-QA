/*
Descrição
Neste desafio, vamos criar um programa que simula um algoritmo para registrar falhas em testes de um sistema. O programa solicitará ao usuário que insira o nome do teste e a descrição do erro correspondente. Em seguida, ele exibirá uma mensagem do erro formatado.

Entrada
A entrada do programa consiste em duas strings. A primeira string deve conter o nome do teste que falhou, e a segunda string deve conter a descrição do erro ocorrido durante o teste.

Saída
A saída do programa consiste em uma string formatada da seguinte maneira:
"O teste falhou: Descrição do erro: [descricaoDoErro]"
*/

using System;

namespace SimulacaoFalhaTeste {
  class Program {
    static void Main(string[] args) {
      // TODO: Solicite ao usuário que digite o nome do teste:

      // TODO: Solicite ao usuário que digite a descrição do erro:
          
      var titulo = Console.ReadLine();
      var descricaoDoErro = Console.ReadLine();
      // Se o teste falhar, exibe a descrição do erro:
      Console.WriteLine($"O teste falhou. Descricao: {descricaoDoErro}");
    }
  }
}