using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeCore;

namespace TicTacToeCoreUnitTest
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void InitializeBoardTest()
        {
            Board board = new Board(3,3);
            board.InitializeBoard();
            Cell[,]cells = board.Cells;
            Assert.AreEqual(9,cells[2, 2].Position); 

        }

        [TestMethod]
        public void UpdateBoardTest()
        {
            MarkType crossmark = new Cross();
            Board b1 = new Board(3,3);
            b1.UpdateBoard(crossmark,1);
            string marktAtZeroZero = b1.Cells[0, 0].CellMark.Mark;
            Assert.AreEqual(crossmark.Mark,marktAtZeroZero);
        }


    }
}
