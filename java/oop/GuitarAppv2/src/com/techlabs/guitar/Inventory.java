package com.techlabs.guitar;

import java.util.ArrayList;
import java.util.Iterator;


public class Inventory {
	private ArrayList<Instrument> inventory;
	public Inventory(){
		inventory = new ArrayList<Instrument>();
	}

	public void addInstrument(String serialNumber, double price, InstrumentSpec spec) {
		Instrument instrument = new Instrument(serialNumber,price,spec);
		inventory.add(instrument);
	}
	
	public Instrument get(String serialNumber){
		for(Iterator i = inventory.iterator();i.hasNext();){
			Instrument instrument = (Instrument)i.next();
			if(instrument.getSerialNumber().equals(serialNumber)){
				return instrument;
			}
		}
		return null;
	}
	
	
	// search
	public ArrayList<Instrument> search(InstrumentSpec searchSpec){
		ArrayList<Instrument> matchingInstruments = new ArrayList<Instrument>();
		for(Iterator i = inventory.iterator();i.hasNext();){
			Instrument instrument = (Instrument)i.next();
			if(instrument.getSpec().matches(searchSpec)){
				matchingInstruments.add(instrument);
			}
		}
		return matchingInstruments;
	}
	

}
