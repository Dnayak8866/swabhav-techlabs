package com.techlabs.factory.method;

class Bmw  implements IAutomobile{
	@Override
	public void start() {
		System.out.println("Bmw starts.........");
		
	}

	@Override
	public void stop() {
		System.out.println("Bmw stops...........");
		
	}

}
