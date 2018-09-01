package com.techlabs.employee;

public class QA  extends Employee{
	private double hra_allowance;
	private double totalAllowances;
	
	
	public QA(String name,int salary){
		super(name,salary);
	}
	
	public String  getAllowance(){
		String allowances ="HRA :"+this.hra_allowance;
		return allowances;
	}
	
	public  void calculateCTC(){
		double totalAllowances= calculateAllowances();
		totalSalary+=totalAllowances;
	}
	private double calculateAllowances() {
		this.hra_allowance=(0.2*basicSalary);
		this.totalAllowances=(this.hra_allowance);
		return totalAllowances;
	}
	

}
