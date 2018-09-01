package com.techlabs.icrudable;

public class CustomerDb implements Icrudable {

	@Override
	public void create() {
		System.out.println("Customer's create operation");
		
	}

	@Override
	public void read() {
		System.out.println("Customer's create operation");
	}

	@Override
	public void update() {
		System.out.println("Customer's update operation");
		
	}

	@Override
	public void remove() {
		System.out.println("Customer's remove method");
		
	}
	

}
