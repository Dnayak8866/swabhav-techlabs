package com.techlabs.employe.analyzer;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;

public class EmployeeDataAnalyzer {
	Employee employee, maxEmployee;

	private ArrayList<Employee> employeeList ;


	
	

	public EmployeeDataAnalyzer(Parser parser) {

		this.employeeList = new ArrayList<Employee>(parser.parseData());
		
	}
	
	
	
	public void getMaximumSalariedEmployee() {
		int listSize = employeeList.size();
		maxEmployee = employeeList.get(0);
		for (int i = 1; i < listSize; i++) {

			if (maxEmployee.getSalary() > employeeList.get(i).getSalary()) {

			} else {
				maxEmployee = employeeList.get(i);
			}
		}
		System.out.println("Empolyee with Maximum Salary is : " + "\nName :"
				+ maxEmployee.getEmployeeName() + "\nEmployee Id :"
				+ maxEmployee.getEmployeeID() + "\nDesignation :"
				+ maxEmployee.getDesignation() + "\nManager Id:"
				+ maxEmployee.getDesignationID() + "\nDepartment No:"
				+ maxEmployee.getDepartmentNo() + "\nSalary :"
				+ maxEmployee.getSalary());
		System.out.println("---------------------------------------------------------");
	}

	public void getNoOfEmployeeOnDesignation() {
		int listSize = employeeList.size();
		HashMap<String,Integer> designationMap = new HashMap<String, Integer>();
		HashMap<Integer,Integer> deptNoMap = new HashMap<Integer, Integer>();
		
		int count=1;
		for (int i = 0; i < listSize; i++) {
			String designation =employeeList.get(i).getDesignation();
			int deptNo = employeeList.get(i).getDepartmentNo();
			
			if(designationMap.containsKey(designation)){
				designationMap.put(designation,(designationMap.get(designation))+count);
				
			}else{
				designationMap.put(designation,count);
			}
			
			if(deptNoMap.containsKey(deptNo)){
				deptNoMap.put(deptNo, (deptNoMap.get(deptNo))+count);
			}else{
				deptNoMap.put(deptNo, count);
			}
			
			
		}
		
		int noPresident=designationMap.get("'PRESIDENT'");
		int noManager=designationMap.get("'MANAGER'");
		int noClerk=designationMap.get("'CLERK'");
		int noAnalyst = designationMap.get("'ANALYST'");
		int noSalesman = designationMap.get("'SALESMAN'");
		System.out.println("Total  Employees designationwise....");
		System.out.println("President :" + noPresident);
		System.out.println("Manager :" + noManager);
		System.out.println("Clerk :" + noClerk);
		System.out.println("Analyst :" +noAnalyst);
		System.out.println("Salesman :" + noSalesman);
		System.out.println("--------------------------------------------------------------------");
		System.out.println("Total :"+(noPresident+noManager+noClerk+noAnalyst+noSalesman));
		System.out.println("--------------------------------------------------------------------");
		System.out.println("Total Employee departmentwise....");
		System.out.println("Department No 10 :"+deptNoMap.get(10));
		System.out.println("Department No 20 :"+deptNoMap.get(20));
		System.out.println("Department No 30 :"+deptNoMap.get(30));
		
	}
	
}
