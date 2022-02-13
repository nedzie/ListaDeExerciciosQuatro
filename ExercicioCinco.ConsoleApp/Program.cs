using System;

namespace ExercicioCinco.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Variáveis

            Random rnd = new Random();
            int pontuacaoJogadorUm = 0, pontuacaoJogadorDois = 0, rodada = 0;
            string[] jogador = { "", "" };
            int[] pontos = { 0, 0 };


            // Entradas

            Console.WriteLine("Digite o nome do 1º jogador: ");
            jogador[0] = Console.ReadLine();
            Console.WriteLine("\nDigite o nome do 2º jogador: ");
            jogador[1] = Console.ReadLine();
            Console.Clear();


            // Processamento

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine((i + 1) + "ª rodada");
                pontuacaoJogadorUm = rnd.Next(7);
                Console.WriteLine(jogador[0] + ": " + pontuacaoJogadorUm);
                pontuacaoJogadorDois = rnd.Next(7);
                Console.WriteLine(jogador[1] + ": " + pontuacaoJogadorDois);
                if (pontuacaoJogadorUm == pontuacaoJogadorDois)
                {
                    Console.WriteLine("Ambos os jogadores tiraram " + pontuacaoJogadorUm + ", nenhum pontuou!\n"); // Empate
                }
                else if (pontuacaoJogadorUm > pontuacaoJogadorDois)
                {
                    pontos[0]++;
                    Console.WriteLine("O jogador " + jogador[0] + " jogou " + pontuacaoJogadorUm + " venceu a " + (i + 1) + "ª rodada!\n"); // JogadorUm vence
                }
                else if (pontuacaoJogadorDois > pontuacaoJogadorUm)
                {
                    pontos[1]++;
                    Console.WriteLine("O jogador " + jogador[1] + " jogou " + pontuacaoJogadorDois + " venceu a " + (i + 1) + "ª rodada!\n"); // JogadorDois vence
                }
                rodada++;

            }

            // Saídas


            if (rodada == 3)
            {
                if (pontuacaoJogadorUm == pontuacaoJogadorDois)
                {
                    Console.WriteLine(jogador[0] + ": " + pontuacaoJogadorUm + "\n" + jogador[1] + ": " + pontuacaoJogadorDois +
                        "\nHouve um empate definitivo, tentem novamente!");
                    goto fim;
                }
            }


            if (pontos[0] > pontos[1])
            {
                Console.WriteLine("Parabéns " + jogador[0] + ", você ganhou o jogo!");
            }
            else if (pontos[1] > pontos[0])
            {
                Console.WriteLine("Parabéns " + jogador[1] + ", você ganhou o jogo!");
            }

        fim:
            Console.ReadKey();
        }
    }
}