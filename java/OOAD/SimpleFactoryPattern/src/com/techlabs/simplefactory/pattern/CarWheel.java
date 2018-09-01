package com.techlabs.simplefactory.pattern;

public class CarWheel implements Wheel {
	protected String style;
	protected float diameter;

	public CarWheel(String style,float diameter) {
		this.diameter=diameter;
		this.style=style;
	}

	@Override
	public String getStyle() {
		return style;
	}

	@Override
	public float getDiameter() {
		return diameter;
	}

	
	

}
