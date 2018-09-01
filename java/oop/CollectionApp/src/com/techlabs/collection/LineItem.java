package com.techlabs.collection;

public class LineItem {
	private int id;
	private int quantity;
	private String name;
	private double price;

	public LineItem(String name, int id, double price,int quantity) {
		this.name = name;
		this.id = id;
		this.price = price;
		this.quantity=quantity;
	}
	public int getId(){
		return this.id;
	}
	public String getItemName(){
		return this.name;
	}
	public int getQuantity(){
		return this.quantity;
	}
	public double getPrice(){
		return this.price;
	}
	public double totalCost() {
		double totalCost;
		totalCost = this.quantity * price;
		return totalCost;
	}
}
