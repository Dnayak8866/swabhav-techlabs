package com.techlabs.account.test;

import com.techlabs.datastructure.sorted.account.Account;

public class TestAccntCount {
	public static void main(String arg[]){
	
		Account ac3 = new Account(111, "Dharmesh",500);
		Account ac4 = new Account(112, "D",500);
		
		System.out.println("Count :"+ac3.getCount());
		System.out.println("Head count is"+Account.HeadCount());
		
		System.out.println("Count :"+ac4.getCount());
		System.out.println("Head count is"+Account.HeadCount());
	}
	
	
	
	
	
}
