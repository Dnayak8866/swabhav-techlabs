package com.techlabs.college;

public class Person {
	private int id;
	private String address;
	private String dob;
	private String name;
	private Branch branch;

	
	public Person(String name,String address,String dob,int id,Branch branch){
		this.name=name;
		this.address=address;
		this.dob=dob;
		this.id=id;
		this.branch=branch;
	}
	public int getId() {
		return this.id;
	}

	public String getAddress() {
		return this.address;
	}
	
	public String getDob(){
		return this.dob;
	}
	
	public String getName(){
		return this.name;
	}
	
	public Branch getBranch(){
		return this.branch;
	}
}
