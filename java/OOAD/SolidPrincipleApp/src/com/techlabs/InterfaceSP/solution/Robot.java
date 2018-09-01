package com.techlabs.InterfaceSP.solution;

public class Robot implements Work{

	@Override
	public void startWork() {
		System.out.println("Start work.....Robot");
		
	}

	@Override
	public void stopWork() {
		System.out.println("Stop work.....Robot");
		
	}

}
