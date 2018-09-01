package com.techlabs.cutomexception;

public class CustomException extends Exception {
	
	
	private String s;
	public CustomException(String s){
		this.s =s;	
	}
	
	public String getMessage(){
		return this.s;
	}
	
	

}
