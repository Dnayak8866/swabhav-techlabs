package com.techlabs.facade.pattern;

public class Admin {
	private College mechanical;
	private College comp;
	
	public Admin(){
		mechanical = new Mechanical();
		comp = new ComputerScience();
	}
	
	public void mechDepartment(){
		mechanical.branch();
		mechanical.headOfDepartment();
	}
	public void computerDepartment(){
		comp.branch();
		comp.headOfDepartment();
	}

}
