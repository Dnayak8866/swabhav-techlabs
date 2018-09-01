package com.techlabs.facade.pattern;

public class Mechanical implements College {

	@Override
	public void branch() {
		System.out.println("Mechanical.....");

	}

	@Override
	public void headOfDepartment() {
		System.out.println("Mechanical head.....");

	}

}
