package com.techlabs.dependency.inversion.solution;

public class EmailLogger implements Logger{

	@Override
	public void Log(Exception e) {
		System.out.println(e+"Log is send to your Email .....");
		
	}

}
