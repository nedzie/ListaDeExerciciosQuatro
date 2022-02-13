using System;

namespace ExercicioTres.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Digite a hora atual:");
                string resposta = "";
                int horaAtual = Convert.ToInt32(Console.ReadLine());
                if (horaAtual >= 6 && horaAtual < 13)
                {
                    resposta = "Bom dia!";
                }
                else if (horaAtual >= 13 && horaAtual < 18)
                {
                    resposta = "Boa tarde!";
                }
                else if (horaAtual > 18 && horaAtual < 24 || horaAtual >= 0 && horaAtual < 6)
                {
                    resposta = "Boa noite!";
                }
                Console.WriteLine(resposta + "\n");
            }
        }
    }
}