package com.techlabs.college.test;

import com.techlabs.college.Branch;
import com.techlabs.college.Person;
import com.techlabs.college.Professor;
import com.techlabs.college.Student;

public class TestPerson {
	public static void main(String[] args) {
		Student s1 = new Student("Dharmesh", 1111, "my address", "22/12/1995",
				Branch.COMPUTER);
		displayPerson(s1);
		
		
		Professor p1 = new Professor("profesor-a", "professor-add", "11/11,1989", 222, Branch.COMPUTER, 9);
		p1.calculateSalary();
		displayPerson(p1);

	}

	private static void displayPerson(Person obj) {
	
		Professor p=null;
		String name = obj.getClass().getSimpleName();
		System.out.println(name + "............ :");
		if (name.equalsIgnoreCase("student")) {
			System.out.println(" Name : " + obj.getName() + "\n Id : "
					+ obj.getId() + "\n Address : " + obj.getAddress()
					+ "\n DOB : " + obj.getDob() + "\n Branch :"
					+ obj.getBranch());

		}
		else{
			p=(Professor)obj;
			
			System.out.println(" Name : " + p.getName() + "\n Id : "
					+ obj.getId() + "\n Address : " + p.getAddress()
					+ "\n DOB : " + p.getDob() + "\n Branch :"
					+ p.getBranch()
					+"\n Salary :"+p.getSalary());
		}
		
	
	}

}
