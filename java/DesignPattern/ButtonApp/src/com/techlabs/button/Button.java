package com.techlabs.button;

import java.util.ArrayList;

public class Button implements ButtonObservable {
	private String buttonName;
	private String action;
	private int width;
	private int height;
	private boolean isPress=false;
	private String name;
	private ArrayList<ButtonPressObserver> observers;
	
	public Button(String buttonName,int width,int height) {
		this.buttonName=name;
		this.width=width;
		this.height=height;
		this.observers= new ArrayList<ButtonPressObserver>();
	}
	
	public void press(){
		if(isPress){
			this.action="Saving....";
			this.isPress=false;
		}else{
			this.action="Deleting....";
			this.isPress=true;
		}
		for(ButtonPressObserver observer:observers){
			observer.action(action);
		}
		
		
	}

	@Override
	public void addObserver(ButtonPressObserver observer) {
		observers.add(observer);
		
	}

	@Override
	public void removeObserver(ButtonPressObserver observer) {
		observers.remove(observer);
		
	}
	

	
}
