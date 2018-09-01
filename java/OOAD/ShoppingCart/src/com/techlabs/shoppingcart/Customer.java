package com.techlabs.shoppingcart;

import java.security.AllPermission;
import java.util.ArrayList;

public class Customer {
	
	private String name;
	private int id;
	private ArrayList<Order> allOrders = new ArrayList<Order>();
	public Customer(String name, int id) {
		this.name=name;
		this.id=id;
		
	}
	public ArrayList<Order> getAllOrders(){
		return allOrders;
	}
	
	public String getName(){
		return this.name;
	}
	public int getId(){
		return this.id;
	}
	public void addCustomerOrders(Order order){
		allOrders.add(order);
	}
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return "All orders of customer "+this.name.toUpperCase()+"\n"+allOrders;
	}
	

}
