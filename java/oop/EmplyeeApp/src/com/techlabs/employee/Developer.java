package com.techlabs.employee;

public class Developer extends Employee{
	
	private double ta_allowance;
	private double hra_allowance; 
	private double totalAllowances;
	
	public Developer(String name,int salary){
		super(name,salary);
	}
	
	public String  getAllowance(){
		String allowances ="HRA :"+this.hra_allowance+"\nTA :"+this.ta_allowance;
		return allowances;
	}
	
	public void calculateCTC(){
		double totalAllowances= calculateAllowances();
		totalSalary+=totalAllowances;	
	}
	
	private double calculateAllowances() {
		
		this.ta_allowance=(0.3*basicSalary);
		this.hra_allowance=(0.2*basicSalary);
		this.totalAllowances=(this.hra_allowance+this.ta_allowance);
		return totalAllowances;
	}
}
