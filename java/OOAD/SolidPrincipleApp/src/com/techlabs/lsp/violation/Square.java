package com.techlabs.lsp.violation;

public class Square  extends Rectangle{
	public Square(int side){
		super(side,side);
	}
	
	public void setWidth(int side){
		this.width=this.height=side;
	}
	public void setHeight(int side){
		this.height=this.width=side;
	}

}
