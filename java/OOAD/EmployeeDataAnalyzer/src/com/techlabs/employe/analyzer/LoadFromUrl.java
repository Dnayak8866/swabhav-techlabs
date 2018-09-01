package com.techlabs.employe.analyzer;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.ArrayList;

public class LoadFromUrl implements DataFetcher {
	//TODO load file from url
	private ArrayList<String> employeedetails;
	public LoadFromUrl() {
		employeedetails=new ArrayList<String>();
	}

	@Override
	public ArrayList<String> loadData() {
		String employeedetail;
		try {
			URL url = new URL("https://swabhav-tech.firebaseapp.com/emp.txt");
			BufferedReader reader = new BufferedReader(new InputStreamReader(url.openStream()));
			while((employeedetail=reader.readLine())!=null){
				employeedetails.add(employeedetail);
			}
		} catch (MalformedURLException e) {
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return employeedetails;
	}

}
