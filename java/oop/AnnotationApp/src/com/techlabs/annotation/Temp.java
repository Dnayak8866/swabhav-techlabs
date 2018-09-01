package com.techlabs.annotation;


 @interface NeedsToChaneg{
	boolean value();
}
class Temp{
	@NeedsToChaneg(value=true)
	public void hello(){
		System.out.println("Hello.....");
	}
	public void hi(){
		System.out.println("Hii.....");
	}
	@NeedsToChaneg(value = true)
	public void helloWorld(){
		System.out.println("Hello World.....");
	}
	
}
