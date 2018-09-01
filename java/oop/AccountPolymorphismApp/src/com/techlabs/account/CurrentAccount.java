package com.techlabs.account;

public class CurrentAccount extends Account{
	public CurrentAccount(int acno,String  acntname,double balance){
		super(acno,acntname,balance);
	}
	public void withdraw(double amt){
		if((this.balance-amt)<(-5000)){
			System.out.println("Cannot withdraw....Limit Exceed");
		}else{
			this.balance=this.balance-amt;
		}

	}

}
