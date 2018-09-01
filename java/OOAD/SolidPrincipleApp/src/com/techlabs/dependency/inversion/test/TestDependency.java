package com.techlabs.dependency.inversion.test;

import com.techlabs.dependency.inversion.LogType;
import com.techlabs.dependency.inversion.TaxCalculator;

public class TestDependency {
	public static void main(String[] args) {
		
		TaxCalculator taxCalculator0 = new TaxCalculator(LogType.DB);
		taxCalculator0.calculateTax(40, 2);
		
		TaxCalculator taxCalculator1 = new TaxCalculator(LogType.EMAIL);
		taxCalculator1.calculateTax(0, 0);
		
		TaxCalculator taxCalculator2 = new TaxCalculator(LogType.DB);
		taxCalculator2.calculateTax(0, 0);
		
		TaxCalculator taxCalculator3 = new TaxCalculator(LogType.TXT);
		taxCalculator3.calculateTax(0, 0);
		
	}

}
