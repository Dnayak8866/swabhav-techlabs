package com.techlabs.ocp.solution;

public class FixedDeposit {
	private String name;
	private double principal;
	private int duration;
	private Festival festival;

	public FixedDeposit(String name, double principal, int duration,
			Festival festival) {
		this.name = name;
		this.principal = principal;
		this.duration = duration;
		this.festival = festival;
	}

	public double calculateInterest() {
		double interest;
		if(this.festival!=null){
			interest = this.principal * this.duration * festival.getRate();
		}else{
			interest = this.principal * this.duration * 0.06;
		}
		
		return interest;
	}

}
