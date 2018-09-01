package com.techlabs.tictactoe;

public class Game {
	private ResultAnalyzer analyser;
	private Board board;
	private Player player1;
	private Player player2;
	private GameStatus gameStatus;
	private Player currentPlayer;
	private Mark currentMark;
	private boolean turn=true;
	
	

	
	public Game(ResultAnalyzer analyser,Board board,Player player1,Player player2){
		this.gameStatus=GameStatus.ONGOING;
		this.analyser=analyser;
		this.board=board;
		this.player1=player1;
		this.player2=player2;
		this.currentPlayer=getPlayerTurn();
	
	}
	

	public void play(int position){
		
		this.currentPlayer=getPlayerTurn();
		board.updateBoard(getPlayerTurn().getMark(), position);

		this.gameStatus =analyser.generateResult(board);
		if(this.gameStatus==GameStatus.WON){
			
		}else{
			if(turn){
				turn =false;
			}else{
				turn =true;
			}
		}
		
		board.display();
		System.out.println(this.gameStatus);
		
	}
	
	public GameStatus getGameStatus(){
		return gameStatus;
	}
	public Player getPlayerTurn(){
		if(turn){
			return this.player1;
		}else{
			return this.player2;
		}
		
	}
	
	public Player getCurrentPlayer(){
		return this.currentPlayer;
	}
	
	
}
