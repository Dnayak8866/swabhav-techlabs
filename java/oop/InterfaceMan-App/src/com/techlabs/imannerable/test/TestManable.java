package com.techlabs.imannerable.test;

import com.techlabs.imannerable.Boy;
import com.techlabs.imannerable.Iemotionable;
import com.techlabs.imannerable.Imanable;
import com.techlabs.imannerable.Man;

public class TestManable {
	public static void main(String[] args) {
		
		Man man = new Man();
		Boy boy = new Boy();
		atThePArk(man);
		atThePArk(boy);
		//atTheCinemas(man);
		atTheCinemas(boy);
		
	
	}

	private static void atThePArk(Imanable obj) {
		System.out.println("Imanable...........");
		obj.wish();
		obj.depart();
	}
	
	private static void atTheCinemas(Iemotionable obj) {
		System.out.println("Iemotionable........");
		obj.cry();
		obj.laugh();
	}
	

}
