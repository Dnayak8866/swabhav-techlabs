package com.techlabs.account;

public class SavingAccount extends Account {
	public SavingAccount(int acno,String  acntname,double balance) {
		super(acno,acntname,balance);
	}
	public void withdraw(double amt){
		if(this.balance-amt<=500){
			System.out.println("Cannot withdraw....Limit Exceed");
		}else{
			this.balance=this.balance-amt;
		}
	}

}
