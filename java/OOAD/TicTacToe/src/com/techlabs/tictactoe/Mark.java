package com.techlabs.tictactoe;

public enum Mark {
	NOUGHT, CROSS, N;
	public String toString() {
		switch (this) {
		case NOUGHT:
			return "O";

		case CROSS:
			return "X";

		case N:
			return "N";
		default:
			return null;
		}
	}
}
