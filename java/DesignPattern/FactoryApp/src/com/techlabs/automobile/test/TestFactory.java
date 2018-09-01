package com.techlabs.automobile.test;

import com.techlabs.automobile.AutoType;
import com.techlabs.automobile.AutomobileFactory;
import com.techlabs.automobile.IAutomobile;

public class TestFactory {
	public static void main(String[] args) {
		AutomobileFactory autoFactory;
		autoFactory= AutomobileFactory.getInstance();
		IAutomobile automobile = autoFactory.make(AutoType.TESLA);
		automobile.start();
		automobile.stop();
		System.out.println("Class Name:"+automobile.getClass().getSimpleName());
		
	}

}
