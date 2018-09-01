package com.techlabs.InterfaceSP.violation;

public class Robot implements Iworker {

	@Override
	public void startwork() {
		System.out.println("Start work.....Robot");
		
	}

	@Override
	public void stopWork() {
		System.out.println("Stop work.....Robot");
		
	}

	@Override
	public void startEat() {
		throw new RuntimeException("Violating ISP......");
		
	}

	@Override
	public void stopEat() {
		throw new RuntimeException("Violating ISP......");
		
	}
	
}
