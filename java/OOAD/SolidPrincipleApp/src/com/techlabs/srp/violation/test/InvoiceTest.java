package com.techlabs.srp.violation.test;

import com.techlabs.srp.violation.Invoice;

public class InvoiceTest {
	public static void main(String[] args) {
		Invoice invoice1 = new Invoice(1, "Mobile Phone", 20000, 2, 12);
		invoice1.calculateDiscount();
		invoice1.calculateTax();
		invoice1.calculateTotalCost();
		invoice1.printInoice();
		
		
	}

}
