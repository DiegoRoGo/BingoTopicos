using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoWCF.Dominio.Acciones
{
    public class FillBoard
    {
        public Modelos.Board boardsGenerator()
        {
            Random num = new Random();
            int max = 15;
            int min = 1;
            var carton = new Modelos.Board();    

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    var nCell = new Modelos.Cell(num.Next(min, max));
                    carton.GameBoard.SetValue(nCell, i,j);               
                }
                min = min + 15;
                max = max + 15;
            }
            return carton;
        }

    }
}
