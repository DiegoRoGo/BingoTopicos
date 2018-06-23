using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WcfBingo.Dominio.Modelos;

namespace WcfBingoTests
{
    [TestClass]
    public class ServiceBingoTests
    {
        private WcfBingo.ServiceBingo client = new WcfBingo.ServiceBingo();

        [TestMethod]
        public void GenerateBoardsTest()
        {
            List<Board> Players = client.GenerateBoards(5);
            Assert.AreEqual(5, Players.Count);

        }
        [TestMethod]
        public void GenerateWinningPattern()
        {
            Board Pattern = client.GenerateWinningPattern();
            Assert.IsNotNull(Pattern);
        }

        [TestMethod]
        public void MarkBoardsTest()
        {
            //Player board init
            List<Board> Boards = new List<Board>();
            Boards.Add(new Board());
            Boards[0].SetDefault();
            Boards[0].GameBoard[0][0].Value = 90;
            
            //Tests if the board is not marked where the 90 is
            Assert.IsFalse(Boards[0].GameBoard[0][0].IsMarked);
            //Marks the board
            client.MarkBoards(ref Boards, 90);
            //Tests if the board is marked where the 90 is
            Assert.IsTrue(Boards[0].GameBoard[0][0].IsMarked);
        }

        [TestMethod]
        public void GetWinningPlayersTest()
        {
            //Player board init
            List<Board> Boards = new List<Board>();
            Boards.Add(new Board());
            Boards[0].SetDefault();
            Boards[0].GameBoard[0][0].Value = 90;

            //Mark board
            client.MarkBoards(ref Boards, 90);

            //Generate a winning pattern of one corner
            Board WinningPattern = new Board();
            WinningPattern.SetDefault();
            WinningPattern.GameBoard[0][0].IsMarked = true;

            //Validate if the board won
            Assert.AreEqual(1, client.GetWinningBoards(Boards, WinningPattern).Count);
        }
    }
}
