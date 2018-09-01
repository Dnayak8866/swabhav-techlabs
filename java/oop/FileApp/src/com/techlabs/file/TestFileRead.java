package com.techlabs.file;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class TestFileRead {
	public static void main(String arg[])throws FileNotFoundException,IOException,NullPointerException{
		
		StringBuffer stringbuffer= new StringBuffer();
		String line;
		File file= new File("N:\\Localrepository\\helloworld.txt");
		BufferedReader buffer= new BufferedReader(new FileReader(file));
		while((line=buffer.readLine())!=null){
			
			stringbuffer.append(line);
			stringbuffer.append("\n");
			
		}
		//data+=(buffer.readLine().toString());
		System.out.println(stringbuffer.toString());
		buffer.close();
		
	}
}
