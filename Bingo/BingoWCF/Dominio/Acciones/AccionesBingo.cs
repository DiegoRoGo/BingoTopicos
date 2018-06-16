using BingoWCF.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoWCF.Dominio.Acciones
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
                        if (Player.GameBoard[i, j].Value == number)
                        {
                            Player.GameBoard[i, j].IsMarked = true;
                            marked = true;
                            break;
                        }
                    }
                    if (marked)
                        break;
                }
            }
        }

        public List<Board> GetWinningBoards(List<Board> players, bool[,] winningPattern)
        {
            bool winner;
            List<Board> WinningPlayers = new List<Board>();
            foreach(Board Player in players)
            {
                winner = true;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                        if (winningPattern[i, j] && !Player.GameBoard[i, j].IsMarked)
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
    }
}
