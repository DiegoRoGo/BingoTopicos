using WcfBingo.Dominio.Modelos;
using WcfBingo.Dominio.Validaciones;
using System.Collections.Generic;

namespace WcfBingo.Dominio.Especificaciones
{
    public class EspecificacionesBingo
    {
        public void MarkBoards(ref List<Board> Players, int number)
        {
            new Acciones.AccionesBingo().MarkBoards(ref Players, number);
        }

        public List<Board> GetWinningBoards(List<Board> players, Board winningPattern)
        {
            return new Acciones.AccionesBingo().GetWinningBoards(players, winningPattern);
        }

        public List<Board> GenerateBoards(int amount)
        {
            List<Board> Boards = new List<Board>();
            for (int i = 1; i <= amount; i++)
            {
                Board newBoard = null;
                do
                {
                    newBoard = new Acciones.AccionesBingo().GenerateBoard();
                } while (new ValidacionesBingo().BoardAlreadyRegistered(newBoard, Boards));
                Boards.Add(newBoard);
            }
            return Boards;
        }

        public Board GenerateWinningPattern()
        {
            return new Acciones.AccionesBingo().GenerateWinningPattern();
        }
    }
}
