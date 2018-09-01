package com.techlabs.inheritance.constructor.test;

import com.techlabs.inheritance.constructor.B;

public class TestConstructor {
	public static void main(String arg[]){
		B b = new B(4);
		System.out.println(b.getFoo());
		B b2 = new B(5);
		System.out.println(b2.getFoo());
	}

}
