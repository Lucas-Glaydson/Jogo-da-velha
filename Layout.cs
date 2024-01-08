using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    public class Layout
    {
        public string[][] Linhas { get; set; }

        public Layout()
        {
            Linhas = new string[3][];
            for (int i = 0; i < 3; i++)
            {
                Linhas[i] = new string[3];
            }
        }

        public void MakeLines()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Linhas[i][j] = "_";
                    Console.Write(Linhas[i][j] + "  ");
                }
                Console.WriteLine();
            }
        }

        public void ShowGame()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Linhas[i][j] + "  ");
                }
                Console.WriteLine();
            }
        }
        public void AddItem(int x, int y)
        {
            if (Linhas[x][y] != "X" && Linhas[x][y] != "O")
            {
                Linhas[x][y] = "X";
            }
        }

        public void ComputerChoice()
        {
            Random random = new();

            while (true)
            {
                int x = random.Next(0, 3);

                int y = random.Next(0, 3);

                if (Linhas[x][y] != "X" && Linhas[x][y] != "O")
                {
                    Linhas[x][y] = "O";
                    break;
                }
                else
                {
                    x = 0;
                    y = 0;
                }
            }
        }

        public bool EndGame(string jogador)
        {

            if (VerifyLine(jogador) || VerifyDiag(jogador))
            {
                if (jogador == "X")
                {
                    Console.WriteLine("Você Ganhou!");
                    return true;
                }
                else if (jogador == "O")
                {
                    Console.WriteLine("Você Perdeu!");
                    return true;
                }
            }

            return false;
        }

        public bool VerifyLine(string jogador)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ((Linhas[i][0] == jogador && Linhas[i][1] == jogador && Linhas[i][2] == jogador) ||
                        (Linhas[0][i] == jogador && Linhas[1][i] == jogador && Linhas[2][i] == jogador))
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public bool VerifyDiag(string jogador)
        {
            if (Linhas[0][0] == jogador && Linhas[1][1] == jogador && Linhas[2][2] == jogador ||
            Linhas[0][2] == jogador && Linhas[1][1] == jogador && Linhas[2][0] == jogador)
            {
                return true;
            }
            return false;
        }
    }
}
