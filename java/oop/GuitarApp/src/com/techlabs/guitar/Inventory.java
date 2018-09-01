package com.techlabs.guitar;

import java.util.ArrayList;
import java.util.Iterator;

public class Inventory {
	ArrayList<Guitar> guitars = new ArrayList<Guitar>();

	public void addGuitar(String serialNumber, double price, Builder builder,
			String model, Type type, Wood backWood, Wood topWood) {
		Guitar guitar = new Guitar(serialNumber, price, new GuitarSpec(builder,
				model, type, backWood, topWood));
		guitars.add(guitar);
	}
	
	public Guitar getGuitar(String serialNumber){
		for(Iterator i = guitars.iterator();i.hasNext();){
			Guitar guitar = (Guitar)i.next();
			if(guitar.getSerialNumber().equals(serialNumber)){
				return guitar;
			}
		}
		return null;
	}
	
	public ArrayList<Guitar> search(GuitarSpec searchSpec){
		ArrayList<Guitar> matchingGuitars = new ArrayList<Guitar>();
		for(Iterator i = guitars.iterator();i.hasNext();){
			Guitar guitar = (Guitar)i.next();
			GuitarSpec guitarSpec = guitar.getSpec();
			if(searchSpec.getBuilder()!=guitarSpec.getBuilder())
					continue;
			
			String model = searchSpec.getModel();
			if((model!=null) && (!model.equals("")) && (!model.equals(guitarSpec.getModel().toLowerCase())))
					continue;
			
			if(searchSpec.getType()!=guitarSpec.getType())
				continue;
			
			if(searchSpec.getBackWood()!=guitarSpec.getBackWood())
				continue;
			
			if(searchSpec.getTopWood()!=guitarSpec.getTopWood())
				continue;
			
			matchingGuitars.add(guitar);		
		}
		return matchingGuitars;
	}

}
