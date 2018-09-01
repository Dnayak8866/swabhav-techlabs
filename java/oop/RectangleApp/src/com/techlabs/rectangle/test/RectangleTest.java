package com.techlabs.rectangle.test;

import com.techlabs.rectangle.Rectangle;
public class RectangleTest {
	public static void main(String args[])throws NoSuchMethodException {
		testObjectReference();
		testAnonymousObject();
		
		
	
	}

	private static void testAnonymousObject() {
		printDetails(new Rectangle());
	}

	private static void testObjectReference() throws NoSuchMethodException {
		Rectangle rectangleOne = new Rectangle();
		
		
		rectangleOne.setWidth(105);
		rectangleOne.setHeight(-1);
		System.out.println("Height is : "+rectangleOne.getHeight());
		System.out.println("Width is : "+rectangleOne.getWidth());
		System.out.println("Area is : "+rectangleOne.calculateArea());
		System.out.println("-------------------------------------------------");
		
		rectangleOne.setborderColor("RED");
		
		Rectangle rectangletwo = rectangleOne;
		System.out.println(rectangletwo.getBorderColor());
		rectangletwo.setborderColor("Green");
		
		System.out.println(rectangletwo.getBorderColor());
		System.out.println(rectangleOne.getBorderColor());
		
	/*	System.out.println("After null.....");
	    rectangletwo=null;
		System.out.println(rectangleOne.getBorderColor());
		System.out.println("-------------------------------------------------");
		System.out.println(rectangletwo.getBorderColor());
	 
	 */
		
		System.out.println("Object Three calling");
		Rectangle rectangleThree = new Rectangle();
		rectangleThree.setHeight(50);
		rectangleThree.setWidth(50);
		rectangleThree.setborderColor("Blue");	
		
	}
	//printDetails 
	public static void printDetails(Rectangle object){
		System.out.println("Height is : "+object.getHeight());
		System.out.println("Width is : "+object.getWidth());
		System.out.println("Area is : "+object.calculateArea());
		System.out.println(object.getBorderColor());
		
		
	}

}
