package com.techlabs.tictactoe;

import static org.junit.Assert.*;

import org.junit.Test;

public class GameTestCase {

	@Test
	public void testGame() {
		Board gameBoard = new Board(3, 3);
		System.out.println("........Game Begins...........");
	
		ResultAnalyzer analyser = new ResultAnalyzer(gameBoard);
		Player player1 = new Player("Dharmesh", Mark.CROSS);
		Player player2 = new Player("Chandan", Mark.NOUGHT);
		Game game = new Game(analyser, gameBoard, player1, player2);
		game.play(1);
		game.play(4);
		game.play(2);
		game.play(5);
		game.play(7);
		game.play(6);
		
		
		
	}

}
