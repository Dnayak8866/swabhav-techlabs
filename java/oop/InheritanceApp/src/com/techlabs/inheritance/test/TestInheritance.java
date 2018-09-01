package com.techlabs.inheritance.test;

import com.techlabs.inheritance.Boy;
import com.techlabs.inheritance.Infant;
import com.techlabs.inheritance.Kid;
import com.techlabs.inheritance.Man;

public class TestInheritance {
	public static void main(String arg[]){
		testMan();
		System.out.println("--------------------------------------------------");
		testBoy();
		System.out.println("--------------------------------------------------");
		testManBoy();
		System.out.println("--------------------------------------------------");
		testPolymorphism();
	}

	private static void testPolymorphism() {
		atThePark(new Man());
		atThePark(new Boy());
		atThePark(new Kid());
		atThePark(new Infant());
	}

	private static void testManBoy() {
		Man x;
		x = new Boy();
		//will call override method play of Boy
		x.play();
		//will call Man's read() and wish()
		x.read();
		x.wish();
		
	}

	private static void testBoy() {
		Boy b = new Boy();
		b.play();
		b.read();
		b.wish();
		b.eat();
		
	}

	private static void testMan() {
		Man x = new Man();
		x.read();
		x.play();
		x.wish();
		
	}
	private static void atThePark(Man x){
		System.out.println("At the Park");
		x.play();
	}
	
}
