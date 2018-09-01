package com.techlabs.automobile;

public class AutomobileFactory {
	private static AutomobileFactory autoFactory;
	
	public  static IAutomobile make(AutoType autoType){
		switch(autoType){
		case AUDI:
			return	new Audi();
		case BMW:
			return new Bmw();
		case TESLA:
			return new Tesla();
		
		}
		return null;
	}
	public static AutomobileFactory getInstance(){
		if(autoFactory==null){
			autoFactory = new AutomobileFactory();
		}
		return autoFactory;
	}

}
