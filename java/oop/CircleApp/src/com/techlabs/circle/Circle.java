package com.techlabs.circle;

public class Circle {
	private static final float PI = 3.14f;
	float radius;

	
	
	private BorderOptions option;
	
	public Circle(float d, BorderOptions option ){
		
		this.option = option;
		this.radius = d;
	}
	
	public double getDouble(){
		return this.radius;
	}
	
	public BorderOptions getBorderOption(){
		return this.option;
	}
	
	public double calculateArea(){
		System.out.println("Area of Circle is: "+(PI*radius*radius));
		return (PI*radius*radius);
	}


}
