package com.techlabs.DougDogDoor;


import java.util.TimerTask;

public class Remote {
	private DogDoor door;
	
	public Remote(DogDoor d){
		this.door=d;
	}
	
	public void pressButton(){
		System.out.println("Pressing the remote Control button.........");
		if(door.isOpen()){
			door.close();
		}else{
			door.open();
			
		}
	}

}
