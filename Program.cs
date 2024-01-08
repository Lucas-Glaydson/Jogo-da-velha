using JogoDaVelha;
using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 0, y = 0;
        Layout layout = new();

        Console.WriteLine("=====Jogo da Velha=====\n");
        layout.MakeLines();

        while (true)
        {
            Console.WriteLine();

            if (layout.EndGame("X") || layout.EndGame("O"))
            {
                break;
            }

            do
            {
                Console.WriteLine("Escolha a Linha (Um valor de 1 até 3)");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Escolha a Coluna (Um valor de 1 até 3)");
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

            } while (x > 3 || x <= 0 || 0 >= y || y > 3);

            if (layout.EndGame("X") || layout.EndGame("O"))
            {
                break;
            }

            layout.AddItem(x-1, y-1);

            layout.ShowGame();
            Console.WriteLine();

            Thread.Sleep(1000);

            layout.ComputerChoice();
            Console.WriteLine();

            layout.ShowGame();
            Console.WriteLine();
        }
    }
}
