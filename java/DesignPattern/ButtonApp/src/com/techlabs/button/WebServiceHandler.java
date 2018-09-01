package com.techlabs.button;

public class WebServiceHandler implements ButtonPressObserver {

	@Override
	public void action(String action) {
		System.out.println("WebserviceHandler doing action "+action);
		
	}

}
