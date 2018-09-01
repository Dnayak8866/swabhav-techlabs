package com.techlabs.dependency.inversion.solution;

public class DbLogger implements Logger {

	@Override
	public void Log(Exception e) {
		System.out.println(e+"Log is send to Database File.....");
		
	}

}
