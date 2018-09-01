package com.techlabs.college;

public enum Branch {
	COMPUTER, MECHANICAL, ELECTRICAL, ELECTRONICS, CIVIL;

	public String  toString(){
		switch(this){
		case COMPUTER:
			return "Computer";
		case MECHANICAL:
			return "Mechanical";
		case ELECTRICAL:
			return "Electrical";
		case CIVIL:
			return  "Civil";
		}
		return "no branch selected";
	}
}
