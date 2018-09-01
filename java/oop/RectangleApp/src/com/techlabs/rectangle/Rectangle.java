package com.techlabs.rectangle;

public class Rectangle {
	//for testing reflection
	public int x,y;
	private int width=20;
	private int height=20;
	private String borderColor="Default color";
	
	//for testing reflection
	public Rectangle(){
		System.out.println("Object created");
	}
	//for testing reflection
	public Rectangle(int x,int y){
		System.out.println("Object created");
	}
	
	public int calculateArea(){
		return width*height;
	}
	
	public void setborderColor(String borderColor){
		this.borderColor =checkBorderColor(borderColor);
	
	}
	
	public void setWidth(int width){
			this.width=checkWidthHeight(width);	
	}
	public void setHeight(int height){
		this.height=checkWidthHeight(height);	
	}
	
	public int getWidth(){
		return this.width;
	}
	
	public int getHeight(){
		return this.height;
	}
	
	public String getBorderColor(){
		return this.borderColor;
	}
	
	private int checkWidthHeight(int value){
		if(value>100){
			return 100;
		}else if(value<1){
			return 1;
		}else{
			return value;
		}
	}
	
	private String checkBorderColor(String bordercolor){
		if(bordercolor.equalsIgnoreCase("red")){
			return "Red";
		}else if(bordercolor.equalsIgnoreCase("blue")){
			return "blue";
		}else if(bordercolor.equalsIgnoreCase("Green")){
			return "Green";
		}else{
			return "No colors";
		}
	}
	
	
	/*public void setHeight(int height){
		if(height>100){
			this.height=100;
		}else if(height<1){
			this.height=1;
		}else{
			this.height=height;
		}
		
	} */
}
