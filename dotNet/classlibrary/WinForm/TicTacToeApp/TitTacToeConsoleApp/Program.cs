using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeCore;

namespace TitTacToeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Board gameBoard = new Board(3, 3);
            Console.WriteLine("........Game Begins...........");
            gameBoard.display();

            ResultAnalyzer analyser = new ResultAnalyzer(gameBoard);
            Player player1 = new Player("Dharmesh", MarkFactory.Cross);
            Player player2 = new Player("Chandan", MarkFactory.Nought);
            Game game = new Game(analyser, gameBoard, player1, player2);


            while (game.GameStatus == GameStatus.ONGOING)
            {


                Console.WriteLine("\nHey " + game.GetPlayerTurn().Name + " its your turn");
                Console.WriteLine("Enter your " + game.GetPlayerTurn().Mark.Mark + " position:");
      
                int position = Convert.ToInt32(Console.ReadLine());
                
                game.play(position);

                if (game.GameStatus == GameStatus.WON)
                {
                   Console.WriteLine(game.GetCurrentPlayer().Name + " Wons");
                    
                }
                else if (game.GameStatus == GameStatus.DRAW)
                {
                    Console.WriteLine("........Game is draw.........");
                }
            }
        }
    }
}
