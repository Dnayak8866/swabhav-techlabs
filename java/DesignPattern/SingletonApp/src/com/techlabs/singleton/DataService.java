package com.techlabs.singleton;

public class DataService {
	private static DataService bucket;
	
	private DataService(){
		System.out.println("Data service created..");
	}
	
	public void processData(){
		System.out.println("Data is processed by Service "+this.hashCode());
	}
	
	public static DataService getInstance(){
		if(bucket==null){
			bucket = new DataService();
		}
		return bucket;
	}

}
