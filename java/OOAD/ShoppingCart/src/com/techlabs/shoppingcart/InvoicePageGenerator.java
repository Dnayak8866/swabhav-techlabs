package com.techlabs.shoppingcart;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;

public class InvoicePageGenerator {
	private Customer customer;
	private Order order;
	private LineItem lineItem;
	private ArrayList<Order> allorders;
	
	public InvoicePageGenerator(Customer customer){
		this.customer=customer;
		
		
	}
	
	public void generateInvoice() throws IOException {
		this.allorders=customer.getAllOrders();
		String name = customer.getName();
		int id = customer.getId();
			
				File htmlFile= new File("resources\\Customer"+id+".html");
				String html ="<html>\n<head>\n<title>\n</title>\n</head>\n<body>\n<pre>\n Customer Name :"+name+"\nCustumer ID :"+id+"\n"+this.allorders+"</pre>\n</body>\n</html>";
				BufferedWriter writer = new BufferedWriter(new FileWriter(htmlFile));
				writer.append(html);
				writer.close();
			
	
		
	}
	
	
	
	
	

}
