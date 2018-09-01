package com.techlabs.decorator;

public class LogDecorator extends BaseTransactionDecorator{

	public LogDecorator(ITransaction transaction) {
		super(transaction);
		
	}
	
	public void deposit(int amt){
		super.deposit(amt);
		System.out.println("Logging before deposit.....");
		
	}
	



	

}
