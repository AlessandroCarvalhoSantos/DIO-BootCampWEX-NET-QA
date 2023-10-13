using System;

namespace AnaliseDadosTeste {
  class Program {
    static void Main(string[] args) {
      // Solicita ao usuário a quantidade de testes bem-sucedidos:
      int testesBemSucedidos = int.Parse(Console.ReadLine());

      // Solicita ao usuário a quantidade de testes totais:
      int testesTotais = int.Parse(Console.ReadLine());
      
      var taxa = (double)testesBemSucedidos/testesTotais * 100;
      
      if(taxa >= 80)
        Console.WriteLine("A funcionalidade esta pronta para lancamento.");
      else
        Console.WriteLine("A funcionalidade nao esta pronta para lancamento.");

      // TODO: Implemente as condições para o cálculo da taxa de sucesso:

      // TODO: Implemente uma estrutura condicional (if/else) para avaliar a taxa de sucesso e tomar decisões com base nela:

    }
  }
}
