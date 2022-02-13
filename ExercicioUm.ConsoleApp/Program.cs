using System;

namespace ExercicioUm.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a largura:");
            int horizontal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a altura:");
            int vertical = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for (int z = 0; z < vertical; z++)
            {
                for (int i = 0; i < horizontal; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}