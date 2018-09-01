package com.techlabs.button;

public interface ButtonObservable {
	public void addObserver(ButtonPressObserver observer);
	public void removeObserver(ButtonPressObserver observer);

}
