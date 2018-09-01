package com.techlabs.ocp.violation.test;

import org.omg.CORBA.PUBLIC_MEMBER;

import com.techlabs.ocp.violation.FestivalType;
import com.techlabs.ocp.violation.FixedDeposit;

public class FixedDepositTest {
	public static void main(String[] args) {
		FixedDeposit deposit = new FixedDeposit("Dharmesh",5000,5,FestivalType.DIWALI);
		System.out.println(deposit.calculateInterest());
	}
}
