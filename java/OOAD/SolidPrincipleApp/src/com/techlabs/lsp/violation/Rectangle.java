package com.techlabs.lsp.violation;

public class Rectangle {
	protected int width;
	protected int height;
	
	public Rectangle(int width,int height){
		this.width=width;
		this.height=height;
	}
	public void setWidth(int w){
		this.width=w;
	}
	public void setHeight(int h){
		this.height=h;
	}
	public int getWidth(){
		return this.width;	
	}
	public int getHeight(){
		return this.height;		
	}
	
	public int calculateArea(){
		return this.height*this.width;
	}
}
