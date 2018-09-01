package com.techlabs.contacts;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;

public class StoreData {



	public  void serializeTheList(ArrayList<Contact> contactList) {
		try {
			FileOutputStream file = new FileOutputStream(
					"resource/serializeContactLists2.ser");
			ObjectOutputStream output = new ObjectOutputStream(file);
			output.writeObject(contactList);
			output.close();
			file.close();
		} catch (Exception e) {
			e.getMessage();
		}
		
	}

	@SuppressWarnings("unchecked")
	public  ArrayList<Contact> getData() throws IOException, ClassNotFoundException {
		ArrayList<Contact> contactlist = new ArrayList<Contact>();
		try{
			
			FileInputStream file = new FileInputStream(
					"resource/serializeContactLists2.ser");
			ObjectInputStream input = new ObjectInputStream(file);
			contactlist= (ArrayList<Contact>) input.readObject();
			input.close();
			file.close();
		}catch(FileNotFoundException e){
			return contactlist;
		}
		
		return contactlist;
		
	}
}
