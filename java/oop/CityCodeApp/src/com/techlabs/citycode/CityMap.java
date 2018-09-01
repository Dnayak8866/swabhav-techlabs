package com.techlabs.citycode;

import java.util.HashMap;
import java.util.Map;

public class CityMap {
	HashMap<CityCode, CityCode> cityMap = new HashMap<CityCode, CityCode>();
	
	public void addCityCode(CityCode c){
		cityMap.put(c, c);
	}
	
	public void checkCityCode(String input){
		boolean anyMatchFound=false;
		for (Map.Entry<CityCode, CityCode> m : cityMap.entrySet()) {
			CityCode singleCityCode = (CityCode) m.getValue();
			
			if(input.equalsIgnoreCase(singleCityCode.getCityCode())){
				anyMatchFound=true;
				System.out.println(input+" stands for "+singleCityCode.getDescription());
				break;
			}else{
				anyMatchFound=false;
			}
			
		}
		if(!anyMatchFound){
			System.out.println("No Match Found.........");
		}
	}

	public void checkCityCodeWithChar(String inputChar) {
		for(Map.Entry<CityCode, CityCode> m :cityMap.entrySet()){
			CityCode singleCityCode = (CityCode) m.getValue();
			String description = singleCityCode.getDescription();
			for(int i=0;i<description.length();i++){
				char c = description.charAt(i);
				String decripchar = String.valueOf(c);
				if(inputChar.equalsIgnoreCase(decripchar)){
					System.out.println("May be you are looking for .."+singleCityCode.getDescription());
					break;
				}
			}
		}
		
	}
	
	

}
