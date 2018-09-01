package com.techlabs.guitar;

public  class Instrument {
	private String serialNumber;
	private double price;
	private InstrumentSpec spec;
	
	public Instrument(String serialNumber,double price,InstrumentSpec spec){
		this.serialNumber=serialNumber;
		this.price=price;
		this.spec=spec;
	
	}
	public String  getSerialNumber(){
		return this.serialNumber;
	}
	public double getPrice(){
		return this.price;
	}
	
	//TODO setters......
	
	public InstrumentSpec getSpec(){
		return spec;
	}
}

