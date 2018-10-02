package com.techlabs.tictactoe.test;

import java.util.Scanner;

import com.techlabs.tictactoe.Board;
import com.techlabs.tictactoe.Game;
import com.techlabs.tictactoe.GameStatus;
import com.techlabs.tictactoe.Mark;
import com.techlabs.tictactoe.Player;
import com.techlabs.tictactoe.ResultAnalyzer;
import com.techlabs.tictactoe.ui.GameUiFrame;

public class TestTicTacToe {
	public static void main(String[] args) {
		
		Board gameBoard = new Board(3, 3);
		System.out.println("........Game Begins...........");
		gameBoard.display();

		ResultAnalyzer analyser = new ResultAnalyzer(gameBoard);
		Player player1 = new Player("Dharmesh", Mark.CROSS);
		Player player2 = new Player("Chandan", Mark.NOUGHT);
		Game game = new Game(analyser, gameBoard, player1, player2);

		while (game.getGameStatus() == GameStatus.ONGOING) {

			
			System.out.println("\nHey " + game.getPlayerTurn().getName() + " its your turn");
			System.out.println("Enter your " +game.getPlayerTurn().getMark()+ " position:");
			Scanner sc1 = new Scanner(System.in);
			int position = sc1.nextInt();
			game.play(position);	
			
			if (game.getGameStatus() == GameStatus.WON) {
				System.out.println(game.getCurrentPlayer().getName() + " Wons");
				sc1.close();
			}else if(game.getGameStatus() == GameStatus.DRAW) {
				System.out.println("........Game is draw.........");
			}
		}

	}

	

}
