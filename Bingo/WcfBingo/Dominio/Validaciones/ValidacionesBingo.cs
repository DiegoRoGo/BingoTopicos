using WcfBingo.Dominio.Modelos;
using System.Collections.Generic;

namespace WcfBingo.Dominio.Validaciones
{
    public class ValidacionesBingo
    {
        public bool BoardAlreadyRegistered(Board board, List<Board> Players)
        {
            foreach(Board player in Players)
            {
                bool Repeated = true;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if(board.GameBoard[i][j].Value != player.GameBoard[i][j].Value)
                        {
                            Repeated = false;
                            break;
                        }
                    }
                    if (!Repeated)
                        break;
                }
                if (Repeated)
                    return true;
            }
            return false;
        }
    }
}