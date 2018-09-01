package com.techlabs.observer.test;

import com.techlabs.observer.Account;
import com.techlabs.observer.EmailNotifier;
import com.techlabs.observer.SmsNotifier;

public class TestObserver {
	public static void main(String[] args) {
		Account ac1 = new Account("Dharmesh", 5000, 111);
		ac1.addListener(new SmsNotifier());
		ac1.addListener(new EmailNotifier());
		ac1.deposit(500);
	}
}
