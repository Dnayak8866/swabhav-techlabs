package com.techlabs.domparserApp;

import java.util.ArrayList;
import java.util.List;

public class ControlGrp implements IdomElement{
	private String grpName;
	private List<IdomElement> childrens;
	private boolean addSpace=false;
	
	public ControlGrp(String name) {
		this.grpName=name;
		this.childrens= new ArrayList<IdomElement>();
	}

	public void addIDomElements(IdomElement elements){
		childrens.add(elements);
	}
	@Override
	public void render() {
		
		
		if(this.addSpace){
			System.out.println("  <"+this.grpName+">");
			this.addSpace=false;
		}else{
			System.out.println("<"+this.grpName+">");
			this.addSpace=true;
		}
		for(IdomElement element : childrens){
			element.render();
		}
		System.out.println("</"+this.grpName+">");
	}
	
	
}
