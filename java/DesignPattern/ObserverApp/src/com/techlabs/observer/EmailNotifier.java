package com.techlabs.observer;

public class EmailNotifier implements BalanceChangeListener {

	@Override
	public void updateBalance(int balance) {
		System.out.println("Updated balance is "+balance);
		System.out.println("Email is sent to your id.....");
	}

}
