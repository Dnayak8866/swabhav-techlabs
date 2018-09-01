package com.techlabs.guitar.test;

import java.util.ArrayList;
import java.util.Iterator;

import com.techlabs.guitar.Builder;
import com.techlabs.guitar.Guitar;
import com.techlabs.guitar.GuitarSpec;
import com.techlabs.guitar.Inventory;
import com.techlabs.guitar.Type;
import com.techlabs.guitar.Wood;

public class FindGuitarTester {
	public static void main(String[] args) {
		Inventory inventory = new Inventory();
		intializeInventory(inventory);
		ArrayList<Guitar> matchingGuitars = new ArrayList<Guitar>();
		
		// what customer wants
		GuitarSpec whatcustomerwants = new GuitarSpec(Builder.FENDER, "model1",
				Type.ELECTRIC, Wood.ALDER, Wood.CEDAR);
		
		matchingGuitars = inventory.search(whatcustomerwants);
		if(!matchingGuitars.isEmpty()){
			for(Iterator i = matchingGuitars.iterator();i.hasNext();){
				Guitar matchingGuitar = (Guitar)i.next();
				GuitarSpec matchingGuitarSpec = matchingGuitar.getSpec();
				System.out.println("We have a "+
				matchingGuitarSpec.getBuilder()+ " "+matchingGuitarSpec.getModel()
				+" "+matchingGuitarSpec.getType()+" guitar:\n "+matchingGuitarSpec.getBackWood()
				+"backs and sides,\n  "+matchingGuitarSpec.getTopWood()
				+"top.\n You can have it for $"+matchingGuitar.getPrice()
				+"!\n------");
			}
		}else{
			System.out.println("Sorry, we have nothing for you.....");
		}
	}

	private static void intializeInventory(Inventory inventory) {
		inventory.addGuitar("1111", 5244, Builder.FENDER, "model1", Type.ELECTRIC,
				Wood.ALDER, Wood.CEDAR);
		inventory.addGuitar("2222", 5230, Builder.FENDER, "model1",
				Type.ELECTRIC, Wood.ALDER, Wood.CEDAR);
		inventory.addGuitar("123", 5230, Builder.MARTIN, "abce", Type.ELECTRIC,
				Wood.ALDER, Wood.CEDAR);
		inventory.addGuitar("123", 5230, Builder.FENDER, "abc", Type.ELECTRIC,
				Wood.ALDER, Wood.CEDAR);

	}

}
