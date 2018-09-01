package com.techlabs.tictactoe;

import static org.junit.Assert.*;

import org.junit.Test;

public class ResultAnalyserTestCase {
	 
	Player player1 = new Player("Dharmesh", Mark.CROSS);
	Mark markCross = player1.getMark();
	Player player2 = new Player("Chandan", Mark.NOUGHT);
	Mark markNought = player2.getMark();
	
	@Test
	public void displayTest() {
		System.out.println(" display test...");
		Board b1 = new Board(3, 3);
		b1.display();
			
	}
	
	@Test
	public void verticalTestCase(){
		System.out.println("Vertical Test case....");
		Board b2 = new Board(3, 3);
		b2.initializeBoard();
		b2.updateBoard(markCross, 2);
		b2.updateBoard(markCross, 5);
		b2.updateBoard(markCross, 8);
		b2.display();
		ResultAnalyzer analyser1 = new ResultAnalyzer(b2);
		assertEquals(GameStatus.WON, analyser1.generateResult(b2));
	}
	
	@Test
	public void horizontalTestCase(){
		System.out.println("horizontal test......");
		Board b3 = new Board(3, 3);
		b3.initializeBoard();
		b3.updateBoard(markCross, 1);
		b3.updateBoard(markCross, 2);
		b3.updateBoard(markCross, 3);
		b3.display();
		ResultAnalyzer analyser2 = new ResultAnalyzer(b3);
		assertEquals(GameStatus.WON, analyser2.generateResult(b3));
	}
	
	@Test
	public void checkDrawCase(){
		System.out.println("Draw case.......");
		Board b4 = new Board(3,3);
		b4.initializeBoard();
		b4.updateBoard(markCross, 1);
		b4.updateBoard(markNought, 2);
		b4.updateBoard(markCross, 3);
		b4.updateBoard(markNought, 4);
		b4.updateBoard(markCross, 5);
		b4.updateBoard(markCross, 6);
		b4.updateBoard(markNought, 7);
		b4.updateBoard(markCross, 8);
		b4.updateBoard(markNought, 9);
		b4.display();
		ResultAnalyzer analyser3 = new ResultAnalyzer(b4);
		assertEquals(GameStatus.DRAW,analyser3.generateResult(b4));
	}
}
