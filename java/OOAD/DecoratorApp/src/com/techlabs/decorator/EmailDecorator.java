package com.techlabs.decorator;

public class EmailDecorator extends BaseTransactionDecorator {
	
	
	public EmailDecorator(ITransaction transaction) {
		super(transaction);
	}

	@Override
	public void deposit(int amt) {
		super.deposit(amt);
		System.out.println("Emailing  deposit");
	}
	
	

}
