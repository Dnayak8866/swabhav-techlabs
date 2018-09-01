package com.techlabs.button;

public class DatabaseHandler implements ButtonPressObserver {

	@Override
	public void action(String action) {
		System.out.println("DatabasHandler doing action "+action);
		
	}

}
