package com.techlabs.icrudable.test;

import com.techlabs.icrudable.CustomerDb;
import com.techlabs.icrudable.Icrudable;
import com.techlabs.icrudable.InvoiceDb;
import com.techlabs.icrudable.VenderDb;

public class IcrudableTest {
	public static void main(String[] args) {
		Icrudable customer = new CustomerDb();
		doCrudOperations(customer);
		
		System.out.println("-------------------------------");
		
		Icrudable vender = new VenderDb();
		doCrudOperations(vender);
		
		System.out.println("-------------------------------");
		
		Icrudable invoice = new InvoiceDb();
		doCrudOperations(invoice);
	}

	private static void doCrudOperations(Icrudable i) {
		i.create();
		i.read();
		i.update();
		i.remove();
		
	}

}
