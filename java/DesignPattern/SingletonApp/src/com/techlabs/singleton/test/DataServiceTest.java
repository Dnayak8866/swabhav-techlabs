package com.techlabs.singleton.test;

import com.techlabs.singleton.DataService;

public class DataServiceTest {
	public static void main(String[] args) {
		DataService s1 ,s2;
		s1=DataService.getInstance();
		s2= DataService.getInstance();
		s1.processData();
		s2.processData();
	}
}
