package com.techlabs.decorator;

public abstract class BaseTransactionDecorator implements ITransaction {
	protected ITransaction transaction;
	public BaseTransactionDecorator(ITransaction transaction) {
		this.transaction=transaction;
	}

	@Override
	public void deposit(int amt) {
		transaction.deposit(amt);
		
	}
	
}
