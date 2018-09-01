package com.techlabs.ocp.violation;

import com.techlabs.ocp.solution.Festival;

public class FixedDeposit {
	private String name;
	private double principal;
	private int duration;
	private FestivalType festivalType;

	public FixedDeposit(String name, double principal, int duration,
			FestivalType festival) {
		this.name = name;
		this.principal = principal;
		this.duration = duration;
		this.festivalType = festival;
	}

	public double calculateInterest() {
		double interest;
		switch (this.festivalType.toString()) {
		case "diwali":
			interest = this.principal * this.duration * (0.08);
			break;
		case "holi":
			interest = this.principal * this.duration * (0.075);
			break;
		case "raksha":
			interest = this.principal * this.duration * (0.07);
			break;

		default:

			interest = this.principal * this.duration * (0.06);
		}
		return interest;

	}

}
