package com.techlabs.DougDogDoor;

import java.awt.print.Book;
import java.util.ArrayList;
import java.util.Timer;
import java.util.TimerTask;

public class DogDoor {
	private boolean open;
	
	private ArrayList<Bark> allowedBarks = new ArrayList<Bark>();
	
	
	public DogDoor(){
		this.open=false;
	}
	
	public void addAllowedBarks(Bark bark){
		allowedBarks.add(bark);
	}
	public ArrayList<Bark> getAllowedBark(){
		return this.allowedBarks;
	}
	public void open(){
		System.out.println("The Dog Door is open...........");
		this.open=true;
		final Timer timer = new Timer();
		timer.schedule(new TimerTask() {
			
			@Override
			public void run() {
				// TODO Auto-generated method stub
				close();
				timer.cancel();
			}
		},5000);
	}
	public void close(){
		System.out.println("The Dog Door is close.........");
		this.open=false;
	}
	public boolean isOpen(){
		return this.open;
	}
	
}
