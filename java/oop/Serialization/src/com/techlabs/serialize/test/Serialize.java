package com.techlabs.serialize.test;

import java.io.Serializable;

public class Serialize  implements Serializable {

	private static final long serialVersionUID = 1111L;
	private String name;
	private int Id;
	
	public Serialize(int id,String name){
		this.Id=id;
		this.name=name;
	}
	public int getId(){
		return this.Id;
	}
	public String getName(){
		return this.name;
	}

	
	

}
