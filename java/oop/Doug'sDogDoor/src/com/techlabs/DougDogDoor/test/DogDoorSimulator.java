package com.techlabs.DougDogDoor.test;

import com.techlabs.DougDogDoor.Bark;
import com.techlabs.DougDogDoor.BarkRecognizer;
import com.techlabs.DougDogDoor.DogDoor;
import com.techlabs.DougDogDoor.Remote;

public class DogDoorSimulator {
	public static void main(String[] args) {
		DogDoor door = new DogDoor();
		door.addAllowedBarks(new Bark("rowlf"));
		door.addAllowedBarks(new Bark("rooowlf"));
		door.addAllowedBarks(new Bark("rawlf"));
		door.addAllowedBarks(new Bark("woof"));
		BarkRecognizer recognizer = new BarkRecognizer(door);
		Remote remote = new Remote(door);
		
		System.out.println("Bruce starts barking......");
		recognizer.recognize(new Bark("rowlf"));
		
		System.out.println("Bruce has gone outside.........");
		
		try{
			Thread.currentThread().sleep(10000);
		}catch(InterruptedException e){	}
		System.out.println("Bruce's all done...");
		System.out.println("....but he's suck outside!");
		
		//test for other dog
		Bark smallDogBark = new Bark("yip");
		System.out.println("A small dogs  starts barking");
		recognizer.recognize(smallDogBark);
		
		try{
			Thread.currentThread().sleep(5000);
		}catch(InterruptedException e){}
		
		//bark gain
		System.out.println("Bruce starts barking.");
		recognizer.recognize(new Bark("rooowlf"));
		
		System.out.println("\nBruce's back inside");
		
	}

}
