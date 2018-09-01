package com.techlabs.srp.solution.test;

import com.techlabs.srp.solution.InvoiceRefractor;
import com.techlabs.srp.solution.PrintInvoice;

public class InvoiceRefractorTest {
	public static void main(String[] args) {
		InvoiceRefractor invoice = new InvoiceRefractor(1, "Mobile Phone", 20000, 2, 12);
		PrintInvoice printInvoice = new PrintInvoice(invoice);
		printInvoice.print();	
	}
	
}
