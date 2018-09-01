package com.techlabs.human.test;

import com.techlabs.human.GenderType;
import com.techlabs.human.Human;

public class HumanTest {
	public static void main(String arg[]){
		
		System.out.println(".......First human.........");
		System.out.println(".......Before  Eat.........");
		Human h1 = new Human("Dharmesh", 21, 5.3f, 55.0f, GenderType.MALE);
		displayDetails(h1);
		
		System.out.println(".......After eat.........");
		h1.eat();
		displayDetails(h1);
		System.out.println(".......After Workout.........");
		h1.workout();
		displayDetails(h1);
		System.out.println();
		
		System.out.println("<---------Your health recommendation----------->");
		h1.healthRecommendation();
		displayDetails(h1);
		
		System.out.println();
		System.out.println(".......Second human.........");
		System.out.println(".......Before Eat .........");
		Human h2 = new Human("Chandan", 22, GenderType.MALE);
		displayDetails(h2);
		
		System.out.println(".......After eat.........");
		h2.eat();
		displayDetails(h2);
		
		System.out.println(".......After Workout.........");
		h2.workout();
		displayDetails(h2);
		
		System.out.println("<---------Your health recommendation----------->");
		h1.healthRecommendation();
		displayDetails(h1);
	
	}
	private static void displayDetails(Human obj){
		System.out.println("Name :"+obj.getName());
		System.out.println("Age :"+obj.getAge());
		System.out.println("Weight :"+obj.getWeight());
		System.out.println("Height :"+obj.getHeight());
		System.out.println("Gender :"+obj.getGender());
	}
	
}
