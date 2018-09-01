package com.techlabs.shoppingcart;

public class Product {
	private int  id;
	private String name;
	private int costprice;
	private int netPayable;
	private int discount;
	
	public Product(int id,String name,int cost,int discount){
		this.id=id;
		this.name=name;
		this.costprice=cost;
		this.discount=discount;
	}
	public int getDiscount(){
		return this.discount;
	}
	
	public int getId(){
		return this.id;
	}
	
	public String getName(){
		return this.name;
	}
	
	public int getCostPrice(){
		return this.costprice;
	}
	
	
	public double calculateCost(){
		return this.netPayable=costprice-((discount*costprice)/100);
	}

}
