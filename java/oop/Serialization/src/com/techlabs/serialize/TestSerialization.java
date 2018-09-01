package com.techlabs.serialize;

import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectOutputStream;


import com.techlabs.serialize.test.Serialize;

public class TestSerialization {
	public static void main(String arg[]) throws FileNotFoundException,IOException{
		Serialize s1 = new Serialize(123, "Dharmesh");
		
		FileOutputStream file = new FileOutputStream("N:\\Localrepository\\java\\oop\\serializeobject.ser");
		ObjectOutputStream output = new ObjectOutputStream(file);
		output.writeObject(s1);
		file.close();
		output.close();
		System.out.println("Object is serialize");
	}
}
