package com.techlabs.ocp.violation;

import java.lang.invoke.SwitchPoint;

public enum FestivalType {
	DIWALI,RAKSHABANDHAN,HOLI,NORMAL;
	
	public String toString(){
		switch(this){
		case DIWALI: 
			return "diwali";
		case RAKSHABANDHAN: 
			return "raksha";
		case HOLI:
			return "holi";
		case NORMAL:
			return "normal";
		default :
			return "unspecified";
		}
		
		
	}
	
}



