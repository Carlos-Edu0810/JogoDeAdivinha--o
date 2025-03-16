# Jogo de Adivinhação

## Descrição
O **Jogo de Adivinhação** é um jogo de console em C# onde o jogador deve tentar adivinhar um número secreto gerado aleatoriamente entre 1 e 100. O jogador tem um total de 10 tentativas para acertar o número.

Este projeto foi desenvolvido para fins didáticos e aprendizado em C#.

## Como Jogar
1. Execute o programa.
2. Escolha a opção **1. JOGAR!** no menu inicial.
3. O jogo escolherá um número aleatório entre 1 e 100.
4. O jogador tem até 10 tentativas para adivinhar o número.
5. A cada tentativa, o jogo informará se o palpite é maior ou menor que o número secreto.
6. Se o jogador acertar, sua pontuação será calculada com base no número de tentativas utilizadas.
7. Se todas as tentativas forem esgotadas, o número secreto será revelado.
8. O jogador pode optar por jogar novamente ou sair do jogo.

## Regras do Jogo
- O número secreto está sempre entre **1 e 100**.
- O jogador tem **10 tentativas** para acertar.
- Se errar, receberá uma dica se o número é maior ou menor que o chute.
- A pontuação inicial é **100 pontos** e diminui **10 pontos por tentativa errada**, com pontuação mínima de **10 pontos**.

## Como Executar
1. Certifique-se de ter o .NET SDK instalado.
2. Compile e execute o programa utilizando o seguinte comando:
   ```sh
   dotnet run
   ```
3. Siga as instruções na tela para jogar.

## Estruturas Utilizadas
- `Random` para gerar o número secreto.
- `while` loops para controle do fluxo do jogo.
- `int.TryParse()` para validar entradas numéricas.
- Métodos auxiliares para tratamento de entrada e cálculo de pontuação.

## Melhorias Futuras
- Implementar um sistema de níveis de dificuldade.
- Criar um sistema de ranking para armazenar pontuações.
- Melhorar a interface do jogo com gráficos simples no console.

## Autor
Este projeto foi desenvolvido para fins didáticos e aprendizado em C#.

**Autor:** Carlos E. S. Ramos

