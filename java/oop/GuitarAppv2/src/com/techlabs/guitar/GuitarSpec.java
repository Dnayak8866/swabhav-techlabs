package com.techlabs.guitar;

public class GuitarSpec extends InstrumentSpec {
	private int numStrings;
	
	public GuitarSpec(Builder builder,String model,Type type,int numString,Wood backWood,Wood topWood ){
		super(builder,model,type,backWood,topWood);
	}
	
	public int getNumbers(){
		return numStrings;
	}
	
	public boolean matches(InstrumentSpec otherSpec){
		if(!super.matches(otherSpec))
			return false;
		if(!(otherSpec instanceof GuitarSpec))
			return false;
		GuitarSpec spec = (GuitarSpec)otherSpec;
		if(numStrings!=spec.numStrings)
			return false;
		return true;
	}
	
	

}
