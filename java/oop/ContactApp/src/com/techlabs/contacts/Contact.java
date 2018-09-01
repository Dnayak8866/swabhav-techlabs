package com.techlabs.contacts;

import java.io.Serializable;
import java.util.ArrayList;

public class Contact implements Serializable {
	private String name;
	private String number;
	
	public Contact(String name,String number){
		
		this.name=name;
		this.number=number;
	}
	
	
	public String toString(){
		return "Name :"+this.name
				+"\nMobile :"+this.number;
	}
}
