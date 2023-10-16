# **DIO - Trilha .NET  Fundamentos - Desafio Estacionamento**
www.dio.me

## Desafio de projeto
​	Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto
​	Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
​	Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:

![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

​	**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

​	**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

​	**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

​	**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

​	**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

​	**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar


## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

- Imagens do Projeto já feito

  <img src="./terminal1.png" width="100%"/>

  <img src="./terminal2.png" width="100%"/>
  
  <img src="./terminal3.png" width="100%"/>
  
  ​		<img src="./terminal4.png" width="100%"/>												

- Além de que foi pedido
  - Criei soluções diferentes para separa e criei uma classe menu para desenhar melhor a tela e gerenciar o fluxo.
  - Além de melhoria no código já existente e validações extras
