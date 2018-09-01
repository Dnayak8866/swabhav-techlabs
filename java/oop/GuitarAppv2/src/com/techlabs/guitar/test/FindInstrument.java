package com.techlabs.guitar.test;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;

import javax.print.attribute.HashAttributeSet;

import com.techlabs.guitar.Builder;
import com.techlabs.guitar.Instrument;
import com.techlabs.guitar.InstrumentSpec;
import com.techlabs.guitar.InstrumentType;
import com.techlabs.guitar.Inventory;
import com.techlabs.guitar.Type;
import com.techlabs.guitar.Wood;

public class FindInstrument {
	public static void main(String[] args) {
		Inventory inventory = new Inventory();
		initializeInventory(inventory);
		
		HashMap<String, Object> properties = new HashMap<String, Object>();
		properties.put("builder", Builder.GIBSON);
		properties.put("backwood", Wood.MAPLE);
		InstrumentSpec clientSpec = new InstrumentSpec(properties);
		
		ArrayList<Instrument> matchingInstruments = inventory.search(clientSpec);
		if(!matchingInstruments.isEmpty()){
			System.out.println("You might like these instruments:");
			for(Iterator i = matchingInstruments.iterator();i.hasNext();){
				Instrument instrument = (Instrument)i.next();
				InstrumentSpec spec = instrument.getSpec();
				System.out.println("We have a "+spec.getProperty("instrumentType")+"with following properties");
				for(Iterator j = spec.getProperties().keySet().iterator();j.hasNext();){
					String propertyName= (String)j.next();
					if(propertyName.equals("instrumentType"))
						continue;
					System.out.println(" " + propertyName + ": "+spec.getProperty(propertyName));
				}
				System.out.println(" You can have this "+spec.getProperty("instrumentType")+" for $"+ instrument.getPrice()
						+"\n----");
			}
		}else{
			System.out.println("Sorry, we have noting for you");
		}
	}

	private static void initializeInventory(Inventory inventory) {
		HashMap<String, Object> properties = new HashMap<String, Object>();
		properties.put("instrumentType", InstrumentType.GUITAR);
		properties.put("builder", Builder.COLLINGS);
		properties.put("model", "CJ");
		properties.put("type", Type.ACOUSTIC);
		properties.put("numString", 6);
		properties.put("topWood", Wood.INDIAN_ROSEWOOD);
		properties.put("backWood", Wood.SITKA);
		inventory.addInstrument("11277", 3999.95, new InstrumentSpec(properties));
		
		
		properties.put("builder", Builder.MARTIN);
		properties.put("model", "D-18");
		properties.put("topWood", Wood.MAHOGANY);
		properties.put("backWood", Wood.ADIRONDACK);
		inventory.addInstrument("122784", 5495.95, new InstrumentSpec(properties));
		
		properties.put("builder", Builder.FENDER);
		properties.put("model", "Stratocastor");
		properties.put("type", Type.ELECTRIC);
		properties.put("topWood", Wood.ALDER);
		properties.put("backWood", Wood.ALDER);
		inventory.addInstrument("V9512", 1549.95, new InstrumentSpec(properties));
		
		properties.put("builder", Builder.GIBSON);
		properties.put("model", "Les Paul");
		properties.put("topWood", Wood.MAPLE);
		properties.put("backWood", Wood.MAPLE);
		inventory.addInstrument("70108276", 2295.95, new InstrumentSpec(properties));
		
		properties.put("model", "SG Reissue");
		properties.put("topWood", Wood.MAHOGANY);
		properties.put("backWood", Wood.ADIRONDACK);
		inventory.addInstrument("8686464", 5495.95, new InstrumentSpec(properties));
		
		
		
	}

}
