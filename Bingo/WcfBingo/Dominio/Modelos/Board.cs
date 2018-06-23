using System.Runtime.Serialization;

namespace WcfBingo.Dominio.Modelos
{
    [DataContract]
    public class Board
    {
        [DataMember]
        public Cell[][] GameBoard { get; set; }

        public Board()
        {
            GameBoard = new Cell[5][];
            for (int i = 0; i < 5; i++)
            {
                GameBoard[i] = new Cell[5];
            }
        }

        public void SetDefault()
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    this.GameBoard[i][j] = new Cell(false);
        }
    }
}
