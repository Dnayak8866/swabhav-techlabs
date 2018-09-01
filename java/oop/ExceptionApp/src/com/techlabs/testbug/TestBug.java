package com.techlabs.testbug;

public class TestBug {
	public static void main(String[] args){
		try {
			m1();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			System.out.println("End of main");
		}
		
	}

	private static void m1() throws Exception {
		m2();
		
		
	}

	private static void m2() throws Exception {
		throw new Exception(" Unknown error");
		
	}
	
}
