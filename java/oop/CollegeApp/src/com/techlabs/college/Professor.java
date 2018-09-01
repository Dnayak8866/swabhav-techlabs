package com.techlabs.college;

public class Professor extends Person implements SalariedEmployee {
	private static final double salaryPerHour;
	private int totalWorkingHours;
	private double totalSalary;
	
	static{
		salaryPerHour=5000;
	}
	
	public Professor(String name,String address,String dob,int id,Branch branch,int workinghours){
		super(name,address,dob,id,branch);	
		this.totalWorkingHours=workinghours;
	}
	
	public double getSalary(){
		return this.totalSalary;
	}
	
	public double calculateSalary(){
		
		this.totalSalary= this.totalWorkingHours*salaryPerHour;
		return totalSalary;
	}
	

}
