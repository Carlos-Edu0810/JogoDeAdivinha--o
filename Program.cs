using System;

class Program
{
    public static void Main(string[] args)
    {
        int menu = 0;
        int numeroSecreto = 0;
        Random random = new Random();
        while (true)
        {
            Console.WriteLine("\nBem-vindo ao Jogo de Advinhação!\n");
            Console.WriteLine("1. JOGAR!");
            Console.WriteLine("2. SAIR!");
            Console.Write("\nEscolha uma opção: ");
            menu = ReceberNumero();

            if (menu > 2 || menu < 1)
            {
                Console.WriteLine("Opção inválida!\n");
                continue;
            }
            else if (menu == 2)
            {
                Console.WriteLine("Obrigado por jogar!");
                break;
            }

            numeroSecreto = random.Next(1, 101);
            Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100!");
            Console.WriteLine("Jogador possui 10 tentativas!");
            int tentativas = 1;

            while (true)
            {
                Console.Write($"\nTentativa {tentativas}: ");
                int chute = ReceberNumero();

                if (tentativas == 10)
                {
                    Console.WriteLine($"\n Tentativas esgotadas, o número secreto era {numeroSecreto}\n");
                    break;
                }

                if (chute == numeroSecreto)
                {
                    Console.WriteLine(MenorMaiorIgual(chute, numeroSecreto, tentativas));
                    break;
                }
                else
                {
                    Console.WriteLine(MenorMaiorIgual(chute, numeroSecreto));
                    tentativas++;
                }
            }
        }
    }

    static int ReceberNumero()
    {
        while (true)
        {
            bool input = int.TryParse(Console.ReadLine(), out int recebendoNumero);
            if (input == false)
            {
                Console.Write("Valor Invalido, Tente novamente: ");
            }
            else
            {
                return recebendoNumero;
            }
        }
    }

    static int Pontuacao(int tentativa)
    {
        int pontuacaoTotal = Math.Max(100 - (tentativa - 1) * 10, 10);
        return pontuacaoTotal;
    }

    static string MenorMaiorIgual(int palpite, int numeroSecreto, int tentativas = 0)
    {
        if (palpite > numeroSecreto)
        {
            return $"\n{palpite} é maior que o Número Secreto";
        }
        else if (palpite < numeroSecreto)
        {
            return $"\n{palpite} é Menor que o Número Secreto";
        }
        else
        {
            return $"\nParabens, voce acertou!!\nPontuação: {Pontuacao(tentativas)}\nTentativas: {tentativas}";
        }
    }
}