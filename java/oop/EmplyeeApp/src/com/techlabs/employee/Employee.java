package com.techlabs.employee;

public abstract class Employee {
	private String name;
	protected double basicSalary;
	protected double totalSalary;
	public static int id=0;
	
	
	public Employee(String name,int basicSalary){
		id++;
		this.name=name;
		this.basicSalary=basicSalary;
		this.totalSalary=this.basicSalary;
	}
	public int  getId(){
		return this.id;
	}
	
	public String getName(){
		return this.name;
	}
	public double getTotalSalary(){
		return this.totalSalary;
	}
	
	public abstract void calculateCTC();
	public abstract String getAllowance();
	

	
}
