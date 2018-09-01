package com.techlabs.employe.analyzer;

import java.util.Date;

public class Employee {
	private Integer employeeId;
	private String name;
	private	String designation;
	private int managerID;
	private double salary;
	private double commission;
	private int departmentNo;
	private String dateOfJoining;
	

	
	public Employee(int employeeId,String name,String designation,int designationId,String date,double salary,double commmision,int departmentNo){
		this.employeeId=employeeId;
		this.name=name;
		this.designation=designation;
		this.managerID=designationId;
		this.dateOfJoining=date;
		this.salary=salary;
		this.commission=commmision;
		this.departmentNo=departmentNo;
	}
	
	public Integer getEmployeeID(){
		return this.employeeId;
	}
	public String getEmployeeName(){
		return this.name;
	}
	
	public String getDesignation(){
		return this.designation;
	}
	public int getDesignationID(){
		return this.managerID;
	}
	public String getJoiningDate(){
		return this.dateOfJoining;
	}
	public double getSalary(){
		return this.salary;
	}
	
	public double getCommision(){
		return this.commission;
	}
	public int getDepartmentNo(){
		return this.departmentNo;
	}
	
	 public int hashCode(){
		return this.employeeId.hashCode();
	}
	
	 @Override
	    public boolean equals(Object obj) {

	    

	        Employee emp=(Employee)obj;

	       
	        if(this.getEmployeeID().equals(emp.getEmployeeID()))
	        {
	                return true;
	        }
	        return false;
	    }
	 
	 
	 
}
