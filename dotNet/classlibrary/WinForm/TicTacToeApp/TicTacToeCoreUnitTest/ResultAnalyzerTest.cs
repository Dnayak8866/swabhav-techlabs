using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeCore;
namespace TicTacToeCoreUnitTest
{
    [TestClass]
    public class ResultAnalyzerTest
    {
       
        public ResultAnalyzerTest()
        {
            Console.WriteLine("Test class constructor...");
        }

        [TestMethod]
        public void VerticalTestCase()
        {
            Player player1 = new Player("Dharmesh", MarkFactory.Cross);
            MarkType markCross = player1.Mark;
            Player player2 = new Player("Chandan", MarkFactory.Nought);
            MarkType markNought = player2.Mark;

            Console.WriteLine("......Vertical Test case....");
            Board b2 = new Board(3, 3);
            b2.InitializeBoard();
            b2.UpdateBoard(markCross, 2);
            b2.UpdateBoard(markCross, 5);
            b2.UpdateBoard(markCross, 8);
            b2.display();
            ResultAnalyzer analyser1 = new ResultAnalyzer(b2);
            Assert.AreEqual(GameStatus.WON,analyser1.GenerateResult(b2));
        }
        [TestMethod]
        public void DiagonalTestCase()
        {
            Player player1 = new Player("Dharmesh", MarkFactory.Cross);
            MarkType markCross = player1.Mark;
            Player player2 = new Player("Chandan", MarkFactory.Nought);
            MarkType markNought = player2.Mark;

            Console.WriteLine("......Diagonal Test case....");

            Board b3 = new Board(3, 3);
            b3.InitializeBoard();
            b3.UpdateBoard(markCross, 3);
            b3.UpdateBoard(markCross, 5);
            b3.UpdateBoard(markCross, 7);
            b3.display();
            ResultAnalyzer analyser2 = new ResultAnalyzer(b3);
            Assert.AreEqual(GameStatus.WON, analyser2.GenerateResult(b3));
        }

        [TestMethod]
        public void HorizontalTestCase()
        {
            Player player1 = new Player("Dharmesh", MarkFactory.Cross);
            MarkType markCross = player1.Mark;
            Player player2 = new Player("Chandan", MarkFactory.Nought);
            MarkType markNought = player2.Mark;

            Console.WriteLine("......Horizontal Test case....");
            Board b4 = new Board(3, 3);
            b4.InitializeBoard();
            b4.UpdateBoard(markNought, 7);
            b4.UpdateBoard(markNought, 8);
            b4.UpdateBoard(markNought, 9);
            b4.display();
            ResultAnalyzer analyser3 = new ResultAnalyzer(b4);
            Assert.AreEqual(GameStatus.WON, analyser3.GenerateResult(b4));
        }

        [TestMethod]
        public void DrawTestCase()
        {
            Player player1 = new Player("Dharmesh", MarkFactory.Cross);
            MarkType markCross = player1.Mark;
            Player player2 = new Player("Chandan", MarkFactory.Nought);
            MarkType markNought = player2.Mark;

            Board b5 = new Board(3, 3);
            b5.InitializeBoard();
            b5.UpdateBoard(markCross, 1);
            b5.UpdateBoard(markNought, 2);
            b5.UpdateBoard(markCross, 3);
            b5.UpdateBoard(markNought, 4);
            b5.UpdateBoard(markCross, 5);
            b5.UpdateBoard(markCross, 6);
            b5.UpdateBoard(markNought, 7);
            b5.UpdateBoard(markCross, 8);
            b5.UpdateBoard(markNought, 9);
            b5.display();
            ResultAnalyzer analyser4 = new ResultAnalyzer(b5);
           
            Assert.AreEqual(GameStatus.DRAW,analyser4.GenerateResult(b5));
        }


    }
}
