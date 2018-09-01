package com.techlabs.player;

public class Player {
	private int id;
	private String name;
	private int age=18;
	
	public Player(int id,String name,int age){
		this(id,name);
		this.age=age;
	}
	public Player(int id,String name){
		//here id contains the heap address of the 
		this.id = id;
		this.name=name;
	}
	
	public int getId(){
		return this.id;
	}
	public String getName(){
		return this.name;
	}
	public int getAge(){
		return this.age;
	}
	
	public boolean equals(Object o){
		Player p = (Player)o;
		if(this.id==p.getId() && this.name==p.getName() && this.age==p.getAge()){
			return true;
		}
		return false;
	}
	public Player whoIsElder(Player player){
		if(this.age>player.age){
			return this;
		}
		return player;
		
		
	}
}
