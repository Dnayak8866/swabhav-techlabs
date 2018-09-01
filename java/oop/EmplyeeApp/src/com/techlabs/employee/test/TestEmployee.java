package com.techlabs.employee.test;

import java.io.IOException;

import com.techlabs.employee.Developer;
import com.techlabs.employee.Employee;
import com.techlabs.employee.ExportData;
import com.techlabs.employee.Manager;

public class TestEmployee {
	public static void main(String[] args) throws IOException {
		Manager m = new Manager("Dharmesh",20000);
		m.calculateCTC();
		printSalarySlip(m);
		ExportData.exportToHtml(m);
		System.out.println("---------------------------------------");
		Developer d = new Developer("Chandan", 20000);
		d.calculateCTC();
		printSalarySlip(d);
		ExportData.exportToHtml(d);
		
		
		
	}

	private static void printSalarySlip(Employee e) throws IOException {
		System.out.println("Name :"+e.getName()+"\nID :"+e.getId()+"\nTotal CTC :"+e.getTotalSalary());
		System.out.println(e.getAllowance());
		
		
	}

}
