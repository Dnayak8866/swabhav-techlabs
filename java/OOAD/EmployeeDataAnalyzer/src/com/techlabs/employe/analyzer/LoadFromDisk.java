package com.techlabs.employe.analyzer;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;


public class LoadFromDisk implements DataFetcher {
	private ArrayList<String> employeedetails;
	public LoadFromDisk(){
		this.employeedetails= new ArrayList<String>();
	}
	

	

	@Override
	public ArrayList<String> loadData() {
		
		String employeedetail;
		
		try {
			File file = new File("resources/dataFile.txt");
			BufferedReader reader = new BufferedReader(new FileReader(file));
			while((employeedetail=reader.readLine())!=null){
				employeedetails.add(employeedetail);
			}
			reader.close();
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
		
		return employeedetails;
	}

}
