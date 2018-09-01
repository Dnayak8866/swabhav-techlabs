package com.techlabs.InterfaceSP.violation;

public class Manager implements Iworker{

	@Override
	public void startwork() {
		System.out.println("Start work.....Manager");
		
	}

	@Override
	public void stopWork() {
		System.out.println("Stop work.....Manager");
		
	}

	@Override
	public void startEat() {
		System.out.println("Start eat.....Manager");
		
	}

	@Override
	public void stopEat() {
		System.out.println("Stop eat.....Manager");	
	}
	
	

}
