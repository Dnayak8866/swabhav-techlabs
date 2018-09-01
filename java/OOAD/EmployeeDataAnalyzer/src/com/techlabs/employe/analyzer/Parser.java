package com.techlabs.employe.analyzer;

import java.awt.List;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Date;
import java.util.HashSet;

import javax.swing.text.html.HTMLDocument.Iterator;

public class Parser {

	private int employeeId;
	private String name;
	private String designation;
	private int designationID;
	private double salary;
	private double commission;
	private int departmentNo;
	private String dateOfJoining;

	private ArrayList<String> emplyeeDetails;
	private HashSet<Employee> employeeDetailsList;

	public Parser() {
		emplyeeDetails = new ArrayList<String>();
	}

	public Parser(ArrayList<String> employeeDetails) {
		this.emplyeeDetails = employeeDetails;
		employeeDetailsList = new HashSet<Employee>();
	}

	public HashSet<Employee> parseData() {
		int size = this.emplyeeDetails.size();

		for (int i = 0; i < size; i++) {
			String singleDetail = emplyeeDetails.get(i);
			String[] partsOfSingleDetails = singleDetail.split(",");
			this.employeeId = Integer.parseInt(partsOfSingleDetails[0]);
			this.name = partsOfSingleDetails[1];
			this.designation = partsOfSingleDetails[2];
			if (!(partsOfSingleDetails[3].equalsIgnoreCase("null"))) {
				this.designationID = Integer.parseInt(partsOfSingleDetails[3]);
			} else {
				this.designationID = 0;
			}

			this.dateOfJoining = partsOfSingleDetails[4];
			this.salary = Integer.parseInt(partsOfSingleDetails[5]);
			if (!(partsOfSingleDetails[6].equalsIgnoreCase("null"))) {
				this.commission = Double.parseDouble(partsOfSingleDetails[6]);
			} else {
				this.commission = 0;
			}

			this.departmentNo = Integer.parseInt(partsOfSingleDetails[7]);

			employeeDetailsList.add(new Employee(this.employeeId, this.name,
					this.designation, this.designationID, this.dateOfJoining,
					this.salary, this.commission, this.departmentNo));

		}
		//System.out.println(employeeDetailsList);
		return employeeDetailsList;
	}


}
