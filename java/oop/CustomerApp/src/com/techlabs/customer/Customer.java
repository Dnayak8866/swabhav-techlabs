package com.techlabs.customer;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

public class Customer {
	private String firstName;
	private String lastName;
	private Date dob;
	private static int id;
	private int customerId;

	static {
		id = 100;
	}

	public Customer(String firstName, String lastName, String dob)throws ParseException {
		id += 1;
		this.customerId = Customer.id;
		this.firstName = firstName;
		this.lastName = lastName;
		this.dob = converToDate(dob);
	}

	public int getCustomerId() {
		return this.customerId;
	}

	public String getFirstName() {
		return this.firstName;
	}

	public String getLastName() {
		return this.lastName;
	}

	private Date converToDate(String dob) throws ParseException {
		Date birthDate = null;
		SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");
		birthDate = sdf.parse(dob);
		return birthDate;
	}

	public String getBirthDate() {
		SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");
		return sdf.format(this.dob);
	}

	public int calculateAge() {
		int currentYear, birthYear, age;
		Date today = new Date();
		SimpleDateFormat sdf = new SimpleDateFormat("yyyy");
		String todaydate = sdf.format(today);
		currentYear = Integer.parseInt(todaydate);

		// System.out.println(todaydate);
		String birthdate = sdf.format(this.dob);
		birthYear = Integer.parseInt(birthdate);
		age = currentYear - birthYear;
		return age;
		// System.out.println(birthdate);
	}

}
