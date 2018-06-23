using System;
using BingoWCF.Dominio.Modelos;

namespace BingoWCF.Dominio.Repositorios
{


    public class Patrones
    {

        public Board GenerateWinningPattern()
        {
            Board pattern = new Board();
            pattern.SetDefault();
            
            switch (new Random().Next(1, 6))
            {
                case 1:
                    pattern = cartonLleno(pattern);
                    break;

                case 2:
                    pattern = esquinas(pattern);
                    break;

                case 3:
                    pattern = letraH(pattern);
                    break;

                case 4:
                    pattern = letraX(pattern);
                    break;

                case 5:
                    pattern = letraU(pattern);
                    break;

            }

            return pattern;
        }
        
        private Board cartonLleno(Board pattern)
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    pattern.GameBoard[i][j].IsMarked = true;
            return pattern;
        }

        private Board esquinas(Board pattern)
        {
            pattern.GameBoard[0][0].IsMarked = true;
            pattern.GameBoard[0][4].IsMarked = true;
            pattern.GameBoard[4][0].IsMarked = true;
            pattern.GameBoard[4][4].IsMarked = true;

            return pattern;
        }

        private Board letraH(Board pattern)
        {
            for (int i = 0; i < 4; i++)
            {
                pattern.GameBoard[i][0].IsMarked = true;
                pattern.GameBoard[i][4].IsMarked = true;
            }
            for (int i = 0; i < 5; i++)
                pattern.GameBoard[2][i].IsMarked = true;
            return pattern;
        }
        
        private Board letraX(Board pattern)
        {
            for (int i = 0; i < 5; i++)
            {
                pattern.GameBoard[i][i].IsMarked = true;
                pattern.GameBoard[i][4-i].IsMarked = true;
            }

            return pattern;
        }
        
        private Board letraU(Board pattern)
        {
            for (int i = 0; i < 4; i++)
            {
                pattern.GameBoard[i][0].IsMarked = true;
                pattern.GameBoard[i][4].IsMarked = true;
            }
            for(int i = 0; i < 5; i++)
                pattern.GameBoard[4][i].IsMarked = true;

            return pattern;
        }
    }
}


