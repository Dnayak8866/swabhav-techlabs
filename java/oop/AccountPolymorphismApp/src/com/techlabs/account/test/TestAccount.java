package com.techlabs.account.test;

import com.techlabs.account.Account;
import com.techlabs.account.CurrentAccount;
import com.techlabs.account.SavingAccount;

public class TestAccount {
	public static void main(String[] args) {
		SavingAccount sa = new SavingAccount(111, "Chandan", 500);
		CurrentAccount ca = new CurrentAccount(222, "Dharmesh", 500);
		sa.depositeAmount(500);
		sa.withdraw(1000);
		printDetails(sa);
		System.out.println("-----------------------------------");
		
		ca.withdraw(5000);
		printDetails(ca);
	}

	private static void printDetails(Account acnt) {
		System.out.println("Account Holder :"+acnt.getAcntName()
				+"\nAccount No :"+acnt.getAcntNo()
				+"\nBalance :"+acnt.getBalance());
	}

}
