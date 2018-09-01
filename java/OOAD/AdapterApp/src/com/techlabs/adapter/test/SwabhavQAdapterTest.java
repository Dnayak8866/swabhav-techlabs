package com.techlabs.adapter.test;

import com.techlabs.adapter.SwabhavQAdapter;

public class SwabhavQAdapterTest  {
	public static void main(String[] args) {
		SwabhavQAdapter<String> nameQueue = new SwabhavQAdapter<String>();
		nameQueue.eQueue("Dharmesh");
		nameQueue.eQueue("Chandan");
		nameQueue.eQueue("Parth");
		nameQueue.eQueue("brijesh");
		nameQueue.eQueue("Aakash");
		nameQueue.eQueue("Abhishek");
		
		
		System.out.println(nameQueue.getCount());
		System.out.println(nameQueue.deQueue());
		System.out.println(nameQueue.getCount());
		for(String name:nameQueue){
			System.out.println(name);
		}
	}
	
	


}
