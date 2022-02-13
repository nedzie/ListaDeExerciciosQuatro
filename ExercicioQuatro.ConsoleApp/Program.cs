using System;

namespace ExercicioQuatro.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variáveis
            int contadorPositivos = 0, contadorNegativos = 0, recebe, total = 0, media = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º:");
                recebe = Convert.ToInt32(Console.ReadLine());
                if (recebe > 0)
                {
                    contadorPositivos++;
                }
                else if (recebe < 0)
                {
                    contadorNegativos++;
                }
                total += recebe; // total = total + recebe
                media = total / 5;
            }
            Console.WriteLine("\nA Média Aritimética é: " + media + "\n" + "A quantidade de valores positivos é: " + contadorPositivos + "\n" +
                "A quantidade de valores negativos é: " + contadorNegativos);
        }
    }
}