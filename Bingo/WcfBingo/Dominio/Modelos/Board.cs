using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoWCF.Dominio.Modelos
{
    public class Board
    {
        public Cell[,] GameBoard { get; set; }

        public Board()
        {
            GameBoard = new Cell[5, 5];
        }

    }
}
