package com.techlabs.datastructure.sorted.account;

import java.util.Comparator;


public class Customer   {
	private int id;
	private String name;

	public Customer(int id, String name) {
		this.id = id;
		this.name = name;
	

	}

	
	public String getName() {
		return this.name;
	}

	/*
	 * public boolean equals(Object o){ Customers c = (Customers)o; return
	 * name.equals(c.getName()); }
	 * 
	 * @Override public int hashCode(){ return name.hashCode(); }
	 */
	@Override
	public String toString() {
		return "Name :" + this.name + " ID :" + this.id+"\n";
	}




}
