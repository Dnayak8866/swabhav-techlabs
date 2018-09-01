package com.techlabs.srp.solution;

public class PrintInvoice {
	private InvoiceRefractor invoice;
	
	public PrintInvoice(InvoiceRefractor invoice){
		this.invoice=invoice;		
	}
	public void print(){
		System.out.println(invoice);
	}

	
}
