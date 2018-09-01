package com.techlabs.shoppingcart;

import java.util.ArrayList;


public class Order {
	ArrayList<LineItem> orderItems = new ArrayList<LineItem>();
	

	
	
	public void addToCart(LineItem item){
		
		
		//check for duplicate item and if found increase quantity
		Product productToAddProduct=item.getProduct();
		int quantity=item.getQuantity();
		if(orderItems.isEmpty()){
			orderItems.add(item);
		}else{
			for(int i=0;i<orderItems.size();i++){
				Product p = orderItems.get(i).getProduct();
				if(productToAddProduct.getName().equalsIgnoreCase(p.getName())){
					LineItem changeLineItem =orderItems.get(i);
					changeLineItem.setQuantity(quantity);
					changeLineItem.calculateItemCost();
					orderItems.set(i, changeLineItem);
					break;
				}else{
					orderItems.add(item);
					break;
				}
			}
		}
		
		
	
		
		
	}
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return "Orders  ...........\n"+
				this.orderItems;
	}
	
	public void displyItems(){
		System.out.println(orderItems);
	}
}
