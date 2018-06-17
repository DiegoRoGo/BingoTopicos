using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoWCF.Dominio.Especificaciones
{
    public class BoardGenerator
    {
        Acciones.FillBoard nCarton;
        public List<Modelos.Board> playBoards;

        public void genplayBoards(int qBoars)
        {
            for (int i = 0; i < qBoars; i++)
            {
                playBoards.Add(nCarton.boardsGenerator());
            }
        }
    }
}
