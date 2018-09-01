package com.techlabs.composite.app;

public class FileElement implements IStorage {
	private String name;
	private String extension;
	
	public FileElement(String fileName,String fileExtension) {
		this.name=fileName;
		this.extension=fileExtension;
	}

	@Override
	public void showDetails() {
		System.out.println("File name :"+this.name+" Extension :"+this.extension);
	}
	
	

}
