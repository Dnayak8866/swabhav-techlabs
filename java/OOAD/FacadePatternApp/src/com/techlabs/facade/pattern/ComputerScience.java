package com.techlabs.facade.pattern;

public class ComputerScience implements College{

	@Override
	public void branch() {
		System.out.println("Computer Science.....");
		
	}

	@Override
	public void headOfDepartment() {
		System.out.println("Computer head....");
		
	}

}
