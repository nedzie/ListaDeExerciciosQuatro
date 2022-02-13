using System;

namespace ExercicioDois.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 2;
            Console.WriteLine("Digite a largura:");
            int horizontal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a altura:");
            int vertical = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for (int z = 0; z < vertical; z++)
            {
                contador++;
                for (int i = 0; i < horizontal; i++)
                {
                    if (contador % 2 == 0)
                    {
                        Console.Write("B");
                    }
                    else
                    {
                        Console.Write("A");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}