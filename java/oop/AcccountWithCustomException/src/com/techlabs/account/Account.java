package com.techlabs.account;

public class Account {
	private int acnt_no;
	private String name;
	private double balance=500;
	private static int count=1000;

	
	static{
		count=1000;
		System.out.println("This is Static Block...");
	}
	public Account(int acnt_no,String name,double balance){
		this(acnt_no,name);
		this.balance = balance;
	}
	public Account(int acnt_no,String name){
		this();
		this.acnt_no = acnt_no;
		this.name = name;	
	}
	public Account(){
		count+=1;
		System.out.println("object created...................");
		System.out.println("This is default constructor......");
	}
	
	public String getName(){
		return this.name;
	}
	
	public int getAcntNo(){
		return this.acnt_no;
	}
	public int getCount(){
		return Account.count;
	}
	
	public static int HeadCount(){
		return Account.count;
	}
	public void deposit(double amt){
		this.balance+=amt;
		System.out.println("Ammout successfully depostied");
	}
	
	public void withdraw(double amt) throws InsuficientFundException {
		
	
		if((this.balance-amt)<=500){
		
			throw new InsuficientFundException("insufficient fund..",this);
			
		}else{
		
			this.balance=this.balance-amt;
		}
	}
	
	@Override
	public String toString(){
		//String s1=super.toString();
		//System.out.println(s1);
		return String.format("Name:"+name+ "\nAccount-No:"+acnt_no+"\nBalance:"+balance);
	}
	

}
