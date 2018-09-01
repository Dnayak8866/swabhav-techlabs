package com.techlabs.shoppingcart;

public class LineItem {
	private Product product;
	private int quantity;
	private double lineItemsPrice;

	public LineItem(Product product, int quantity) {
		this.product = product;
		this.quantity = quantity;
	}
	
	public void setQuantity(int qnty){
		this.quantity+=qnty;
	}
	public int getQuantity(){
		return this.quantity;
	}
	
	public Product  getProduct(){
		return this.product;
	}
	public double calculateItemCost() {
		this.lineItemsPrice = this.product.calculateCost() * this.quantity;
		return this.lineItemsPrice;
	}

	public String toString() {
		return "\nProduct Name:" + this.product.getName() + "\nProduct price:"
				+ this.product.getCostPrice() + "\nProduct Id:"
				+ this.product.getId() + "\nDiscount :"+this.product.getDiscount()+"%"
				+"\nQuantity :" + this.quantity
				+"\nNet Payable Amount :"+this.lineItemsPrice+"\n....................";
	}
}
