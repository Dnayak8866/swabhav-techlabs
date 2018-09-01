package com.techlabs.account;

public class InsuficientFundException extends Exception {
	private Account acntHolder;
	private String s;

	public InsuficientFundException(String s, Account obj) {
		this(s);
		this.acntHolder = obj;
	}

	public InsuficientFundException(String s) {
		this.s = s;
	}

	@Override
	public String getMessage() {
		if (this.acntHolder != null) {
			return this.s + "\n" + acntHolder;
		}
		return this.s;
	}

}
