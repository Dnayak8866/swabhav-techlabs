using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeCore;

namespace TicTacToeCoreUnitTest
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void TestGame()
        {
            Board board = new Board(3,3);
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Player player1 = new Player("Dharmesh", MarkFactory.Cross);
            Player player2 = new Player("Chandan", MarkFactory.Nought);
            Game game = new Game(analyzer, board, player1, player2);
            game.play(1);
            game.play(4);
            game.play(2);
            game.play(5);
            game.play(3);
            game.play(8);
            Assert.AreEqual(GameStatus.WON,game.GameStatus);
        }
    }
}
