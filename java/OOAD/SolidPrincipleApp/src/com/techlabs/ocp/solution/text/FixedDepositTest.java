package com.techlabs.ocp.solution.text;

import com.techlabs.ocp.solution.Diwali;

import com.techlabs.ocp.solution.FixedDeposit;

public class FixedDepositTest {
	public static void main(String[] args) {
	
		FixedDeposit deposit1 = new FixedDeposit("Dharmesh", 5000, 5, new Diwali());
		System.out.println(deposit1.calculateInterest());
		
		FixedDeposit deposit2 = new FixedDeposit("chandan", 5000, 10, null);
		System.out.println(deposit2.calculateInterest());
		
	}

}
