package com.techlabs.employe.analyzer.test;

import com.techlabs.employe.analyzer.EmployeeDataAnalyzer;
import com.techlabs.employe.analyzer.LoadFromDisk;
import com.techlabs.employe.analyzer.Parser;

public class TestEmployeeAnalyzer {
	public static void main(String[] args) {
		Parser parser = new Parser(new LoadFromDisk().loadData());

		EmployeeDataAnalyzer analyzer = new EmployeeDataAnalyzer(parser);
		
		analyzer.getMaximumSalariedEmployee();
		analyzer.getNoOfEmployeeOnDesignation();
		
		System.out.println(".............Data From Url..............");
		
		Parser parser2 = new Parser(new LoadFromDisk().loadData());
		
		EmployeeDataAnalyzer analyzer2 = new EmployeeDataAnalyzer(parser2);
		
		analyzer2.getMaximumSalariedEmployee();
		analyzer2.getNoOfEmployeeOnDesignation();
		
	}

}
