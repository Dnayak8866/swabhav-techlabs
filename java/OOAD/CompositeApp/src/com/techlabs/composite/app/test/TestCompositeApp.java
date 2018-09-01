package com.techlabs.composite.app.test;

import com.techlabs.composite.app.FileElement;
import com.techlabs.composite.app.Folder;

public class TestCompositeApp {
	public static void main(String[] args) {
		Folder root = new Folder("CloudRepository");
		FileElement file1 = new FileElement("ReadMe", "txt");
		root.addItem(file1);
		
		Folder subFolder1 = new Folder("Subfolder1");
		subFolder1.addItem(new FileElement("subfolderfile", "txt"));
		root.addItem(subFolder1);
		
		root.showDetails();
	}

}
