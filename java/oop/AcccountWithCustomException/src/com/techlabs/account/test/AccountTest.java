package com.techlabs.account.test;

import com.techlabs.account.Account;
import com.techlabs.account.InsuficientFundException;

public class AccountTest {
	public static void main(String arg[]){
	/*
		Account ac1 = new Account(111, "Dharmesh", 0);
		ac1.deposit(500);
		ac1.withdraw(500);
		printDetails(ac1);
	*/
		Account ac2 = new Account(12, "me",500);
		try{
			ac2.withdraw(100);
		}catch(Exception ex){
			
			System.out.println(ex.getMessage());
			
		}
		
		
	//	System.out.println(ac2.toString());
		//printDetails(ac2);
	}
	/*private static void printDetails(Account acntObj){
		System.out.println("Name is : "+acntObj.getName()
				+"\nAccount No :"+acntObj.getAcntNo()
				+"\nBalance :"+acntObj.getBalance());
		System.out.println(acntObj);
		System.out.println(acntObj.toString());
		
	}
	*/

}
