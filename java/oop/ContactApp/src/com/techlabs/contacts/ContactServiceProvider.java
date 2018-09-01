package com.techlabs.contacts;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.Serializable;
import java.util.ArrayList;
public class ContactServiceProvider   {
	StoreData s1 = new StoreData();

	public ArrayList<Contact> contactList = new ArrayList<Contact>();
	public ContactServiceProvider() throws ClassNotFoundException, IOException{
		
		this.contactList=s1.getData();
	}
	
	
	public void addContact(String name,String number){
		this.contactList.add(new Contact(name, number));
		// serialize the list
		s1.serializeTheList(this.contactList);
		
	}
	
	public ArrayList<Contact> getNameList(){
		return this.contactList;
	}

	
	
	
	
	

}
