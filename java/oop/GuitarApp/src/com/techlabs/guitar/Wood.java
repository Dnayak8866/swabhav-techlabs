package com.techlabs.guitar;

public enum Wood {
	INDIAN_ROSEWOOD, BRAZILIAN_ROSEWOOD, MAHOGANY, COCOBOLA, CEDAR, ADIRONDACK, ALDER, SITKA;

	public String toSring() {
		switch (this) {
		case INDIAN_ROSEWOOD:
			return "India Rosewood";
		case BRAZILIAN_ROSEWOOD:
			return "Brazilian Rosewosod";
		case MAHOGANY:
			return "Mahogany";
		case COCOBOLA:
			return "Cocobola";
		case CEDAR:
			return "cedar";
		case ADIRONDACK:
			return "Adirondack";
		case ALDER:
			return "Alder";
		case SITKA:
			return "Sitka";

		}
		return null;
	}

}
