package com.techlabs.testdatastructure;

import java.util.HashSet;
import java.util.TreeSet;

import com.techlabs.datastructure.sorted.account.Account;
import com.techlabs.datastructure.sorted.account.AccountNoComparable;
import com.techlabs.datastructure.sorted.account.Customer;
import com.techlabs.datastructure.sorted.account.NameComparable;


public class TestCustomers {
	public static void main(String[] args) {
		Account ac1 = new Account(10, "Abhi", 500);
		Customer c1 = new Customer(1, "Abhi");
		
		Account ac2 = new Account(11, "Chandan");
		Customer c2 = new Customer(2, "Chandan");
		
		Account ac3 = new Account(12, "Dharmesh", 500);
		Customer c3 = new Customer(3, "Dharmesh");
		
		Account ac4 = new Account(11, "Chandan");
		try {

			ac1.withdraw(100);
		} catch (Exception e) {
			System.out.println(e.getMessage());
		}

		//System.out.println(ac1);
		
		
		TreeSet<Customer> customers = new TreeSet<Customer>(new NameComparable());
		customers.add(c1);
		customers.add(c2);
		customers.add(c3);
		
		TreeSet<Account> accounts = new TreeSet<Account>(new AccountNoComparable());
		accounts.add(ac1);
		accounts.add(ac2);
		accounts.add(ac3);
		accounts.add(ac4);
		
		System.out.println("");
		System.out.println("Customers...........");
		System.out.println(customers);
		System.out.println();
		System.out.println("Account Holders..........");
		System.out.println(accounts);
	}
}
