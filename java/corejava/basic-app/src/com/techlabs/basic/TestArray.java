package com.techlabs.basic;

public class TestArray {
	public static void main(String[] args){
		int i=0;
		int marks[] ={80,90,100};
		//String names[] ={"Dharmesh","Abhishek","Chandan"};
		
		for(int mark:marks){
			marks[i]=60;
			System.out.println(marks);
			i++;
		}
		for(int value:marks){
			System.out.println(value);
			
		}
		
	}

}
