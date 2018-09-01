package com.techlabs.calculator;

public class Calculator {
	public int addEvenNumber(int x,int y){
		int z=0;
		if(x%2==0 && y%2==0){
			 z=x+y;
		}
		
		return z;
	}
	
	public double cubeOddNumber(double x){
		double z=0.00;
		if(!(x%2==0)){
			z=(x*x*x);
		}
		return z;
	}

}
