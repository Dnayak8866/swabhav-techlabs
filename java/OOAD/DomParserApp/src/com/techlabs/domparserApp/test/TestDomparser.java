package com.techlabs.domparserApp.test;

import com.techlabs.domparserApp.Control;
import com.techlabs.domparserApp.ControlGrp;

public class TestDomparser {
	public static void main(String[] args) {
		ControlGrp root  = new ControlGrp("html");
		ControlGrp body = new ControlGrp("body");
		
		Control inputTag = new Control("input","text");
		body.addIDomElements(inputTag);
		root.addIDomElements(body);
		
		root.render();
	}

}
