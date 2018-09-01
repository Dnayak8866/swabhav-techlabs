package com.techlabs.player.test;

import com.techlabs.player.Player;

public class PlayerTest {
	public static void main(String arg[]){
		Player  playerone = new Player(1, "Sachin", 40);
		Player  playertwo = new Player(1, "Sachin", 40);
		System.out.println(playerone.hashCode());
		System.out.println(playertwo.hashCode());
		System.out.println(playerone==playertwo);
		System.out.println(playerone.equals(playertwo));
	//	printDetails(playerone);
		Player elderplayer = playerone.whoIsElder(playertwo);
		System.out.println("Elder Player is  "+elderplayer.getName());
			
	}
	private static void printDetails(Player player){
		System.out.println("Name is : "+player.getName()
				+"\nID :"+player.getId()
				+"\nAge :"+player.getAge());
		
	}

}
