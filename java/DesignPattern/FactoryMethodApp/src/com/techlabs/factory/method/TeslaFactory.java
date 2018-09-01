package com.techlabs.factory.method;

public class TeslaFactory  implements IAutoFactory{
	private static TeslaFactory teslaFactory;

	@Override
	public IAutomobile make() {
		
		return new Tesla();
	}
	
	public static TeslaFactory getInstance(){
		if(teslaFactory==null){
			return new TeslaFactory();
		}
		return teslaFactory;
	}
	
	

}
