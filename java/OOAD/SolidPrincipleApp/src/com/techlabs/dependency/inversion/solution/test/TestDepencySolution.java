package com.techlabs.dependency.inversion.solution.test;


import com.techlabs.dependency.inversion.solution.DbLogger;
import com.techlabs.dependency.inversion.solution.EmailLogger;
import com.techlabs.dependency.inversion.solution.TaxCalculater;
import com.techlabs.dependency.inversion.solution.TextLogger;


public class TestDepencySolution {
	public static void main(String[] args) {
		TaxCalculater taxCalculator0 = new TaxCalculater(new EmailLogger());
		taxCalculator0.calculateTax(-40, 2);
		
		TaxCalculater taxCalculator1 = new TaxCalculater(new DbLogger());
		taxCalculator1.calculateTax(0, 0);
		
		TaxCalculater taxCalculator2 = new TaxCalculater(new TextLogger());
		taxCalculator2.calculateTax(20, 2);
		
		
	}

}
