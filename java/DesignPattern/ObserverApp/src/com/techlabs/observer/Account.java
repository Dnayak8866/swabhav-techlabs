package com.techlabs.observer;

import java.util.ArrayList;

import org.w3c.dom.ls.LSInput;

public class Account implements AccountObservable{
	ArrayList<BalanceChangeListener> listeners;
	private String name;
	private int balance;
	private int acntNo;
	BalanceChangeListener listener;
	
	

	public Account(String name,int balance,int accountNo ) {
		this.name=name;
		this.balance=balance;
		this.acntNo=accountNo;
		listeners = new ArrayList<BalanceChangeListener>();
	}

	@Override
	public void addListener(BalanceChangeListener listener) {
		listeners.add(listener);
	
		
	}

	@Override
	public void removeListener(BalanceChangeListener listener) {
		listeners.remove(listener);
		
	}
	public void deposit(int amount){
		this.balance+=balance;
		for(BalanceChangeListener listener : listeners){
			listener.updateBalance(balance);
		}
		
	}
	

}
