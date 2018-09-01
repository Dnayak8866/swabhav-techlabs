package com.techlabs.cutomexception.test;

import com.techlabs.cutomexception.CustomException;

public class TestCustomException {
	public static void main(String arg[]) {
		int x = 10;
		try {
			
			if (checkX(x)) {
				throw new CustomException(" Exception X is greater than 1");
			}

		} catch (CustomException ex) {

			System.out.println(ex.getMessage());
		}
	}

	public static boolean checkX(int x) {
		if (x > 1) {
			return true;
		}
		return false;
	}

}
