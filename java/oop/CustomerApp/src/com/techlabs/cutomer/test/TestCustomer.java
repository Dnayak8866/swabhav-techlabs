package com.techlabs.cutomer.test;

import java.text.ParseException;

import com.techlabs.customer.Customer;

public class TestCustomer {
	public static void main(String arg[])throws ParseException{
		Customer c1 = new Customer("Dharmesh", "Nayak", "22/24/1995");
		Customer c2 = new Customer("Chandan", "Maharana", "22/11/1996");
		
		printDetails(c1);
		System.out.println("--------------------------------------------------------------");
		printDetails(c2);
		System.out.println("--------------------------------------------------------------");
		System.out.println(c1);
		System.out.println(c2);
		
	}
	private static void printDetails(Customer c){
		System.out.println(
				"Firstname :"+c.getFirstName()
				+"\nLastname :"+c.getLastName()
				+"\nBirthdate :"+c.getBirthDate()
				+"\nCustomer Id :"+c.getCustomerId()
				+"\nAge :"+c.calculateAge());
	}
}
