package com.techlabs.simplefactory.pattern;

public class TestSimpleFactory {
	public static void main(String[] args) {
		Wheel carWheel = WheelFactory.makeWheel(10, "Custom");
	     System.out.println(carWheel.getStyle());
	     System.out.println(carWheel.getDiameter());
	}
	 
}
