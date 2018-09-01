package com.techlabs.citycode.test;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.HashMap;
import java.util.Map;

import com.techlabs.citycode.CityCode;
import com.techlabs.citycode.CityMap;


public class CityCodeTest {
	public static void main(String[] args) throws IOException {
		CityMap map = new CityMap();
		CityCode c1 = new CityCode("MH","Maharashtra");
		CityCode c2= new CityCode("GJ","Gujarat");
		CityCode c3= new CityCode("OD", "Odisha");
		map.addCityCode(c1);
		map.addCityCode(c2);
		map.addCityCode(c3);

		boolean isToShow=true;
		while(isToShow){
			
			
			System.out.println("Press 1 for searching on exact CityCode you have :");
			System.out.println("Press 2 if You know the starting character of the citycode :");
			System.out.println("1.Enter the City Code :");
			System.out.println("2.Search for.....");
			System.out.println("----------------------------------------------------------");
			System.out.println("Enter your choice");
			BufferedReader choice = new BufferedReader(new InputStreamReader(System.in));
			int userChoice = Integer.parseInt(choice.readLine());
			switch(userChoice){
			case 1:
				System.out.println("1.Enter the City Code :");
				BufferedReader inputCityCode = new BufferedReader(new InputStreamReader(System.in));
				String inputCode = inputCityCode.readLine().toString();
				map.checkCityCode(inputCode);
				break;
			
			case 2:
				System.out.println("2.Search for..... :");
				BufferedReader inputCharCode = new BufferedReader(new InputStreamReader(System.in));
				String inputChar = inputCharCode.readLine().toString();
				map.checkCityCodeWithChar(inputChar);
				break;
				
				
				
			default :
				isToShow=false;
				System.out.println("Oops wrong input......try again..");
				break;

			}
			
			
		}
				
	}



	
	

}
