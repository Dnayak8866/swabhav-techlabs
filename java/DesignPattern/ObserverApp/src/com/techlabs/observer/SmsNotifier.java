package com.techlabs.observer;

public class SmsNotifier implements BalanceChangeListener{

	@Override
	public void updateBalance(int balance) {
		System.out.println("Updated balance is "+balance);
		System.out.println("Sms is sentto registered number....");
		
	}

}
