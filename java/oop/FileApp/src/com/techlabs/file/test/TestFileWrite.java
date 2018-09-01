package com.techlabs.file.test;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;

public class TestFileWrite {
	public static void main(String arg[])throws FileNotFoundException,IOException{

		File file= new File("N:\\Localrepository\\helloworld.txt");
		BufferedWriter writer = new BufferedWriter(new FileWriter(file,true));
		writer.append(System.lineSeparator());
		writer.append("hey ");
		writer.close();
	}

}
