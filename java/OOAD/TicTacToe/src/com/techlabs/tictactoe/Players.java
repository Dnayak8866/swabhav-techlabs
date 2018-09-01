package com.techlabs.tictactoe;

public class Players<Player> {
	private Player player1,player2;
	public Players(Player player1,Player player2) {
		this.player1=player1;
		this.player2=player2;
	}
	
	public Player getPlayerOne(){
		return this.player1;
	}
	public Player getPlayerTwo(){
		return this.player2;
	}


}
