using BingoWCF.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoWCF.Dominio.Especificaciones
{
    public class EspecificacionesBingo
    {
        public List<int> PlayedNumbers;

        public void MarkBoards(List<Board> Players, int number)
        {
            new Acciones.AccionesBingo().MarkBoards(Players, number);
        }

        public List<Board> GetWinningBoards(List<Board> players, Board winningPattern)
        {
            return new Acciones.AccionesBingo().GetWinningBoards(players, winningPattern);
        }
    }
}
