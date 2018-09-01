package com.techlabs.icrudable;

public class InvoiceDb implements Icrudable {
	@Override
	public void create() {
		System.out.println("Invoice's create operation");
		
	}

	@Override
	public void read() {
		System.out.println("Invoice's create operation");
	}

	@Override
	public void update() {
		System.out.println("Invoice's update operation");
		
	}

	@Override
	public void remove() {
		System.out.println("Invoice's remove method");	
	}

}
