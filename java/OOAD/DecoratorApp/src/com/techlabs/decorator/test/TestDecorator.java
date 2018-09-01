package com.techlabs.decorator.test;

import com.techlabs.decorator.Account;
import com.techlabs.decorator.EmailDecorator;
import com.techlabs.decorator.ITransaction;
import com.techlabs.decorator.LogDecorator;

public class TestDecorator {
	public static void main(String[] args) {
		ITransaction decorator = new EmailDecorator(new LogDecorator(new Account()));
		decorator.deposit(500);	
	}

}
