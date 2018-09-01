package com.techlabs.composite.app;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class Folder implements IStorage{
	private String name;
	private List<IStorage> contents;
	
	public Folder(String name) {
		this.name=name;
		this.contents= new ArrayList<IStorage>();
	}
	
	public void addItem(IStorage item){
		contents.add(item);
	}

	@Override
	public void showDetails() {
		System.out.println("Folder :"+this.name);
		for(IStorage item : contents){
			item.showDetails();
		}
		
	}
	
	

	
	

}
