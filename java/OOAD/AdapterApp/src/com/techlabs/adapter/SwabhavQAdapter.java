package com.techlabs.adapter;

import java.util.Iterator;
import java.util.LinkedList;

public class SwabhavQAdapter<T> implements Iterable<T>{
	private LinkedList<T> nameQueues;

	
	public SwabhavQAdapter() {
		this.nameQueues = new LinkedList<T>();
	}
	public void eQueue(T name){
		nameQueues.addLast((T) name);	
	}
	
	public T deQueue(){
		nameQueues.removeFirst();
		return nameQueues.removeFirst();
		
	}
	
	public int getCount(){
		return nameQueues.size();
	}
	@Override
	public Iterator<T> iterator() {
	
		return nameQueues.iterator();
	}
	
	
	
	

}
