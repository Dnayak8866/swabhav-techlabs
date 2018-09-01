package com.techlabs.serialize;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.ObjectInputStream;

import com.techlabs.serialize.test.Serialize;

public class TestDeserialize  {
	public static void main(String arg[]) throws FileNotFoundException,IOException,ClassNotFoundException {
		try{
			FileInputStream file = new FileInputStream("N:\\Localrepository\\java\\oop\\serializeobject.ser");
			ObjectInputStream inputObject = new ObjectInputStream(file);
			Serialize s = null;
			s=(Serialize)inputObject.readObject();
			inputObject.close();
			file.close();
			System.out.println("Object is deserialized");
			System.out.println("Name :"+s.getName()+"\nId :"+s.getId());
			
		}catch(Exception e){
			
		}
		
	}
}
