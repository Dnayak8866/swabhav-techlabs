package com.techlabs.decorator;

public class Account implements ITransaction {
	private int  balance;
	
	public Account() {
		this.balance=1000;
	}
	
	@Override
	public void deposit(int amt) {
		this.balance+=amt;
		System.out.println("Balance :"+this.balance);
	}
	

}
