package com.techlabs.shoppingcart.test;

import java.io.IOException;

import com.techlabs.shoppingcart.Customer;
import com.techlabs.shoppingcart.LineItem;
import com.techlabs.shoppingcart.Order;
import com.techlabs.shoppingcart.Product;
import com.techlabs.shoppingcart.InvoicePageGenerator;

public class ShoppingCartTest {
	public static void main(String[] args) throws IOException {
		Order ordered1 = new Order();

		Customer c1 = new Customer("Dharmesh", 111);
		Product p1 = new Product(1, "MiA1", 15000, 10);
		LineItem lineitem1 = new LineItem(p1, 1);
		System.out.println(lineitem1.calculateItemCost());
		ordered1.addToCart(lineitem1);

		Product p2 = new Product(2, "RedmiNotePro", 15000, 10);
		LineItem lineitem2 = new LineItem(p2, 1);
		System.out.println(lineitem2.calculateItemCost());
		ordered1.addToCart(lineitem2);

		Product p3 = new Product(2, "MiA1", 15000, 10);
		LineItem lineitem3 = new LineItem(p3, 1);
		System.out.println(lineitem3.calculateItemCost());
		ordered1.addToCart(lineitem3);
		
		c1.addCustomerOrders(ordered1);
		System.out.println(c1);
		
		
		InvoicePageGenerator htmlGenerator = new InvoicePageGenerator(c1);
		htmlGenerator.generateInvoice();
		
		System.out.println("-------------------------------------");

		Order ordered2 = new Order();

		Customer c2 = new Customer("Chandan", 123);
		Product p4 = new Product(1, "MiA2", 15000, 10);
		LineItem lineitem4 = new LineItem(p4, 1);
		System.out.println(lineitem4.calculateItemCost());
		ordered2.addToCart(lineitem4);

		Product p5 = new Product(2, "MiA2", 15000, 10);
		LineItem lineitem5 = new LineItem(p5, 1);
		System.out.println(lineitem5.calculateItemCost());
		ordered2.addToCart(lineitem5);

		c2.addCustomerOrders(ordered2);
		System.out.println(c2);
		
		InvoicePageGenerator htmlGenerator1 = new InvoicePageGenerator(c2);
		htmlGenerator1.generateInvoice();

	}

}
