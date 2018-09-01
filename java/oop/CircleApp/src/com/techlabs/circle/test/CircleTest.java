package com.techlabs.circle.test;

import com.techlabs.circle.BorderOptions;
import com.techlabs.circle.Circle;






public class CircleTest {
	
	public static void main(String arg[]){
		testThreeCircleObject();		
		
	}

	private static void testThreeCircleObject() {
		double sum = 0;
		
		Circle[] circles = new Circle[3];
		circles[0]= new Circle(2.0f, BorderOptions.SINGLE);
		circles[1]= new Circle(1.0f, BorderOptions.DOTTED);
		circles[2]= new Circle(3.0f, BorderOptions.DOUBLE);
		for(int i=0;i<circles.length;i++){
			sum+=circles[i].calculateArea();
		}
		System.out.println("Sum of area of all the Circles are : "+sum);
	}


}
