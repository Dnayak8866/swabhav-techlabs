package com.techlabs.factory.method;

public class AudiFactory implements IAutoFactory {
	private static AudiFactory audiFactory;

	@Override
	public IAutomobile make() {
		
		return new Audi();
	}
	
	public static AudiFactory getInstance(){
		if(audiFactory==null){
			return new AudiFactory();
		}
		return audiFactory;
	}
	
	

}
