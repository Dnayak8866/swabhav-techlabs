package com.techlabs.employee;

public class Manager extends Employee {
	private double hra_allowance;
	private double ta_allowance;
	private double da_allowance; 
	private double totalAllowances;
	
	public Manager(String name,int salary){
		super(name,salary);

	}

	public void calculateCTC(){
		double totalAllowances= calculateAllowances();
		this.totalSalary+=totalAllowances;
		
	}
	private double calculateAllowances() {
		this.hra_allowance=(0.3*basicSalary);
		this.ta_allowance=(0.4*basicSalary);
		this.da_allowance=(0.5*basicSalary);
		this.totalAllowances=(this.hra_allowance+this.da_allowance+this.ta_allowance);
		return totalAllowances;
	}
	public String  getAllowance(){
		String allowances ="HRA :"+this.hra_allowance+"\nTA :"+this.ta_allowance+"\nDA :"+da_allowance;
		return allowances;
	}
	
}
