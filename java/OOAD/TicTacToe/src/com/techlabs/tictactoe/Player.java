package com.techlabs.tictactoe;

public class Player {
	private String name;
	private Mark mark;
	
	public Player(String name,Mark mark){
		this.name=name;
		this.mark=mark;
	}
	public Mark getMark(){
		return this.mark;
	}
	public String getName(){
		return this.name;
	}
}
