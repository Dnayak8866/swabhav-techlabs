package com.techlabs.icrudable;

public class VenderDb implements Icrudable {
	@Override
	public void create() {
		System.out.println("Vender's create operation");
		
	}

	@Override
	public void read() {
		System.out.println("Vender's create operation");
	}

	@Override
	public void update() {
		System.out.println("Vender's update operation");
		
	}

	@Override
	public void remove() {
		System.out.println("Vender's remove method");
		
	}

}
