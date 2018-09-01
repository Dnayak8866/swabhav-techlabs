package com.techlabs.tictactoe;

public class Board {
	private int rows, cols;
	private Cell[][] cells;
	private Cell cell;

	public Board(int row, int col) {
		this.rows = row;
		this.cols = col;
		this.cells = new Cell[this.rows][this.cols];
		initializeBoard();
	}

	public int getNoRows(){
		return this.rows;
	}
	public int getNoColumns(){
		return this.cols;
	}
	// initialize the board with cell objects
	public void initializeBoard() {
		int position=0;
		for (int i = 0; i < rows; i++) {
			for (int j = 0; j < cols; j++) {
				position++;
				cells[i][j] = new Cell(i, j, position);
			}
		}
	}
	
	public Cell[][] getCells(){
		return this.cells;
	}

	
	public void updateBoard(Mark mark,int position){
		for (int i = 0; i < rows; i++) {
			for (int j = 0; j < cols; j++) {
				if(cells[i][j].getPostion()==position){
					cells[i][j].setCellMark(mark);
				}
				
			}
		}
		
	}
	
	
	
	// display board
	public void display() {
		for (int i = 0; i < rows; i++) {
			for (int j = 0; j < cols; j++) {
				if ((j + 1) == cols) {
					System.out.print(" " + cells[i][j]);
				}else{
					System.out.print(" " + cells[i][j] + " |");
				}	
			}
			if(i+1==rows){
				
			}else{
				System.out.println("\n--- --- --- ");	
			}		
		}
		System.out.println("\n");
	}
}
