package com.techlabs.button.test;

import com.techlabs.button.Button;
import com.techlabs.button.DatabaseHandler;
import com.techlabs.button.WebServiceHandler;

public class TestButton {
	public static void main(String[] args) {
		Button b1 = new Button("Save/Delete", 10, 5);
		DatabaseHandler dbHandler = new DatabaseHandler();
		WebServiceHandler wbserviceHandler = new WebServiceHandler();
		b1.addObserver(dbHandler);
		b1.addObserver(wbserviceHandler);
		b1.press();
		b1.press();
		b1.press();
		b1.press();
		b1.removeObserver(wbserviceHandler);
		b1.press();
		
	}

}
