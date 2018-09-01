package com.techlabs.imannerable;

public class Boy implements Imanable,Iemotionable {

	@Override
	public void laugh() {
		System.out.println("Boy laughs.....");
		
	}

	@Override
	public void wish() {
	System.out.println("Boy wishes.......");
		
	}

	@Override
	public void depart() {
		System.out.println("Boy departs.....");
		
	}

	@Override
	public void cry() {
		System.out.println("Boys cry..........");
		
	}

}
