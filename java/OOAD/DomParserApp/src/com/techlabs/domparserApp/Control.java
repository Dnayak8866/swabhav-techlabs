package com.techlabs.domparserApp;

public class Control implements IdomElement{
	private String controlName;
	private String controlType;
	public Control(String controlName,String type) {
		this.controlName=controlName;
		this.controlType=type;
	}
	

	@Override
	public void render() {
		System.out.println("<"+this.controlName+">");
	//	System.out.println("</"+this.controlName+">");
		
	}

}
