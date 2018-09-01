package com.techlabs.citycode;

public class CityCode {
	private String cityCode;
	private String description;
	
	public CityCode(String cityCode,String description){
		this.cityCode=cityCode;
		this.description=description;
	}

	public String getCityCode(){
		return this.cityCode;
	}
	
	public String getDescription(){
		return this.description;
	}
}
