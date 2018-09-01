package com.techlabs.student;

public class Student {
	private int rolNo;
	private int standard;
	private String name;
	
	public Student(String name,int rollNo,int standard){
		this.name=name;
		this.rolNo=rollNo;
		this.standard=standard;
	}
	
	public int getRollNo(){
		return this.rolNo;
	}
	public int getStandard(){
		return this.standard;
	}
	public String getName(){
		return this.name;
	}
	

}
