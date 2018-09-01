package com.techlabs.account;

public abstract class Account {
	private final int acno;
	private final String acnt_Name;
	protected double balance=0;
	public Account(int acno,String  acntname,double balance){
		this.acno=acno;
		this.acnt_Name=acntname;
		this.balance=balance;
	}
	public int getAcntNo(){
		return this.acno;
	}
	public String getAcntName(){
		return this.acnt_Name;
	}
	public double getBalance(){
		return this.balance;
	}
	
	public void depositeAmount(double amt){
		this.balance+=amt;
	}
	public abstract void withdraw(double amt);
}
