using JogoDeXadrez.tabuleiro;
using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDeXadrez
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
