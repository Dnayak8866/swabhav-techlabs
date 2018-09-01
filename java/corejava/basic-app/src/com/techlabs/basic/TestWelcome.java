package com.techlabs.basic;

public class TestWelcome {
	public static void main(String[] args){
		int i;
		System.out.println("Hello World");
		//System.err.println("this is");
		int l =args.length;
		System.out.println("Size of argument[] is :"+l);
		for(i=0;i<l;i++){
			System.out.println("This is: "+args[i]);
		}
		
	}

}
