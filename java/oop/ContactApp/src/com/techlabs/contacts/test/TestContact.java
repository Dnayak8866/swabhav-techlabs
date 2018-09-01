package com.techlabs.contacts.test;

import java.io.BufferedReader;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;
import java.util.ArrayList;
import java.util.Iterator;

import org.w3c.dom.NameList;

import com.techlabs.contacts.ContactServiceProvider;
import com.techlabs.contacts.Contact;

public class TestContact  {

	
	private static  final int add=1,quit=2,display=3;
	public static void main(String[] args) throws IOException, ClassNotFoundException {
		
		

		ContactServiceProvider serviceProvider = new ContactServiceProvider();
		System.out.println("...Add Contact...");
		String name,mob;
	
		boolean isToCheck = true;
		while (isToCheck) {
			System.out.println("1.Add Contact");
			System.out.println("2.Quit");
			System.out.println("3.Display Contact");

			System.out.println("Enter your choice:");
			BufferedReader choice = new BufferedReader(new InputStreamReader(
					System.in));
			int userchoice = Integer.parseInt(choice.readLine());

			switch (userchoice) {
			case add:
				System.out.println("Enter your name :");
				BufferedReader userInputName = new BufferedReader(
						new InputStreamReader(System.in));
				name = userInputName.readLine();

				System.out.println("Enter your contact number :");
				BufferedReader userInputMobileNo = new BufferedReader(
						new InputStreamReader(System.in));
				mob = userInputMobileNo.readLine();

				serviceProvider.addContact(name, mob);
				System.out.println("Contact added successfully....");

			
				break;
			case quit:
				
				isToCheck = false;
				System.out.println("...Oops your are out of Contact app...");
				break;
			case display:
				Iterator<Contact> iterator = serviceProvider.getNameList()
						.iterator();
				while (iterator.hasNext()) {
					System.out.println(iterator.next());
					System.out
							.println("---------------------------------------------");
				}
				
				break;
			}

		}

	}

}
