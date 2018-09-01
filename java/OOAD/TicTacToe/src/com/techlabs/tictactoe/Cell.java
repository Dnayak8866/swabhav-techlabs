package com.techlabs.tictactoe;

public class Cell {
	private Mark mark;
	private int rowIndex;
	private int colIndex;
	private int position;

	public Cell(int rowIndex,int colIndex,int position) {
		this.mark = mark.N;
		this.colIndex=colIndex;
		this.rowIndex=rowIndex;
		this.position=position;
	}



	public void setCellMark(Mark mark) {
		try {
			if (this.mark!=Mark.N) {
				throw new Exception("Mark exists At this Place try again");
			} else {
				this.mark = mark;
			}
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
	
	
		
	public int getPostion(){
		return this.position;
	}
	public int  getRowIndex(){
		return this.rowIndex;
	}
	public int getColIndex(){
		return this.colIndex;
	}
	public Mark getCellMark() {
		return this.mark;
	}
	
	public String toString(){
		return mark.toString();
	}

}
