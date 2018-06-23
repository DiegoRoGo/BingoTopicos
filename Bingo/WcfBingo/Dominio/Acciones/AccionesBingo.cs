using WcfBingo.Dominio.Modelos;
using System;
using System.Collections.Generic;

namespace WcfBingo.Dominio.Acciones
{
    public class AccionesBingo
    {
        public void MarkBoards(List<Board> Players, int number)
        {
            bool marked;
            foreach (Board Player in Players)
            {
                marked = false;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (Player.GameBoard[i][j].Value == number)
                        {
                            Player.GameBoard[i][j].IsMarked = true;
                            marked = true;
                            break;
                        }
                    }
                    if (marked)
                        break;
                }
            }
        }

        public List<Board> GetWinningBoards(List<Board> players, Board winningPattern)
        {
            bool winner;
            List<Board> WinningPlayers = new List<Board>();
            foreach(Board Player in players)
            {
                winner = true;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                        if (winningPattern.GameBoard[i][j].IsMarked && !Player.GameBoard[i][j].IsMarked)
                        {
                            winner = false;
                            break;
                        }
                    if (!winner)
                        break;
                }
                if (winner)
                {
                    WinningPlayers.Add(Player);
                }
            }
            return WinningPlayers;
        }

        public Board GenerateBoard()
        {
            Random num = new Random();
            int max = 15;
            int min = 1;

            Board newBoard = new Board();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    newBoard.GameBoard[i][j] = new Cell(num.Next(min, max+1));
                }
                min = min + 15;
                max = max + 15;
            }

            return newBoard;
        }

        public Board GenerateWinningPattern()
        {
            return new Repositorios.Patrones().GenerateWinningPattern();
        }
    }
}
