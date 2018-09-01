package com.techlabs.collection.test;

import java.util.ArrayList;
import java.util.List;

import com.techlabs.collection.LineItem;

public class GenericTest {
	public static void main(String[] args) {
		List<LineItem> orderedItems = new ArrayList<LineItem>();
		orderedItems.add(new LineItem("Tshirt", 123, 500,2));
		orderedItems.add(new LineItem("jeans", 111, 900, 2));
		orderedItems.add(new LineItem("joggers", 133, 1000, 3));
		orderedItems.add(new LineItem("jeans", 101, 1000, 3));
		
		for(LineItem item:orderedItems){
			System.out.println("Item Name:"+item.getItemName()
					+"\nItem ID :"+item.getId()
					+"\nQuantity :"+item.getQuantity()
					+"\nPrice :"+item.getPrice()
					+"\nTotal Cost :"+item.totalCost());
			System.out.println("-------------------------");
		}
	}

	

}
