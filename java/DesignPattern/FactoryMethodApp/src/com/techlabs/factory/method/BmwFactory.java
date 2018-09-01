package com.techlabs.factory.method;

public class BmwFactory implements IAutoFactory {
	
	private static BmwFactory bmwFactory;
	
	
	@Override
	public IAutomobile make() {
		return new Bmw();
	}



	public static BmwFactory getInstance() {
		if (bmwFactory == null) {
			bmwFactory = new BmwFactory();
		}
		return bmwFactory;
	}
}
