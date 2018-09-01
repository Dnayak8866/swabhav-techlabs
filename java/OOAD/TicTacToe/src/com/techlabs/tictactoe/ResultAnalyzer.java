package com.techlabs.tictactoe;

public class ResultAnalyzer {
	private Board board;
	private Cell[][] cells;
	private GameStatus gameStatus;

	public ResultAnalyzer(Board board) {
		this.board = board;
		this.cells = this.board.getCells();
	}

	public GameStatus generateResult(Board board) {
		this.board = board;
		boolean result;

		for (int i = 0; i < board.getNoRows(); i++) {
			for (int j = 0; j < board.getNoColumns(); j++) {
				if (!(cells[i][j].getCellMark() == Mark.N)) {
					// analyze the cell
					result = analyzeCell(cells[i][j].getPostion());
					if (result) {
						return this.gameStatus = GameStatus.WON;
						
					} else {
						this.gameStatus = GameStatus.ONGOING;
					}
				}
			}
		}
		
		if (checkDrawCase() && (this.gameStatus==GameStatus.ONGOING)) {
			this.gameStatus = GameStatus.DRAW;
		}

		return this.gameStatus;
	}

	private boolean analyzeCell(int position) {
		switch (position) {
		case 1:
			if (checkHorizontalWin(0) || checkVerticalWin(0)
					|| checkDiagonalWin()) {
				return true;
			}
			break;

		case 2:
			if (checkHorizontalWin(0) || checkVerticalWin(1)) {
				return true;
			}
			break;
		case 3:
			if (checkHorizontalWin(0) || checkVerticalWin(2)
					|| checkDiagonalWin()) {
				return true;
			}
			break;
		case 4:
			if (checkHorizontalWin(1) || checkVerticalWin(0)) {
				return true;
			}
			break;
		case 5:
			if (checkHorizontalWin(1) || checkVerticalWin(1)
					|| checkDiagonalWin()) {
				return true;
			}
			break;
		case 6:
			if (checkHorizontalWin(1) || checkVerticalWin(2)) {
				return true;
			}
			break;
		case 7:
			if (checkHorizontalWin(2) || checkVerticalWin(0)
					|| checkDiagonalWin()) {
				return true;
			}
			break;
		case 8:
			if (checkHorizontalWin(2) || checkVerticalWin(1)) {
				return true;
			}
			break;
		case 9:
			if (checkHorizontalWin(2) || checkVerticalWin(2)
					|| checkDiagonalWin()) {
				return true;
			}
			break;
		default:
			return false;

		}
		return false;

	}

	public boolean checkDrawCase() {

		if (this.gameStatus == GameStatus.ONGOING) {
			for (int i = 0; i < board.getNoRows(); i++) {
				for (int j = 0; j < board.getNoColumns(); j++) {
					if (cells[i][j].getCellMark() == Mark.N) {
						return false;
						
					}
				}
			}
		}
		return true;
	}

	private boolean checkDiagonalWin() {

		Mark markAtZeroZeroPosition = cells[0][0].getCellMark();
		Mark markAtTwoZeroPos = cells[2][0].getCellMark();
		if (markAtZeroZeroPosition == cells[1][1].getCellMark()
				&& markAtZeroZeroPosition == cells[2][2].getCellMark()) {
			if (markAtZeroZeroPosition != Mark.N
					&& cells[1][1].getCellMark() != Mark.N
					&& cells[2][2].getCellMark() != Mark.N) {
				return true;
			} else {
				return false;
			}

		} else if (markAtTwoZeroPos == cells[1][1].getCellMark()
				&& markAtTwoZeroPos == cells[0][2].getCellMark()) {
			if (markAtTwoZeroPos != Mark.N
					&& cells[1][1].getCellMark() != Mark.N
					&& cells[0][2].getCellMark() != Mark.N) {
				return true;
			} else {
				return false;
			}

		}
		return false;

	}

	private boolean checkVerticalWin(int col) {

		if (cells[0][col].getCellMark() == cells[1][col].getCellMark()) {
			if (cells[0][col].getCellMark() == cells[2][col].getCellMark()) {
				return true;
			}
		}
		return false;
	}

	private boolean checkHorizontalWin(int row) {
		if (cells[row][0].getCellMark() == cells[row][1].getCellMark()) {
			if (cells[row][0].getCellMark() == cells[row][2].getCellMark()) {
				return true;
			}
		}
		return false;
	}

}
