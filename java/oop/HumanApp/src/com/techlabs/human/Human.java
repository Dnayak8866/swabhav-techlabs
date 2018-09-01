package com.techlabs.human;

public class Human {
	private String name;
	private int age;
	private float height=5.0f;
	private float weight=69.0f;
	private GenderType gender;
	private float bmi;
	
	public Human(String name,int age,float height,float weight,GenderType gender){
		//call second constructor to initialize name,age,gender
		this(name,age,gender);
	
		this.height=height;
		this.weight=weight;
	}
	public Human(String name,int age,GenderType gender){
		this.name=name;
		this.age =age;
		this.gender=gender;
	}
	
	public float getWeight(){
		return this.weight;
	}
	public float getHeight(){
		return this.height;
	}
	public int getAge(){
		return this.age;
	}
	public String getName(){
		return this.name;
	}
	public GenderType getGender(){
		return this.gender;
	}
	
	public void eat(){
		this.weight=this.weight+0.25f;
	}
	public void workout(){
		this.weight = this.weight-0.3f;
		this.height = this.height+0.2f;
	}
	
	public void calculateBMI(){
		this.height = this.height/(3.28f);
		this.bmi = this.weight/(this.height*this.height);
		
	}
	public void healthRecommendation(){
		calculateBMI();
		System.out.println("Your BMI value is : "+this.bmi);
		if(this.bmi>0 && this.bmi<18.5){
			System.out.println("Hey, you are underweight........");
		}else if(this.bmi > 18.5 && this.bmi < 24.9){
			System.out.println("Hey,You hava a Normal Weight");
		}else if(this.bmi > 25 && this.bmi < 29.9){
			System.out.println("hey buddy, you are over weighted.....");
		}else{
			System.out.println("You are suffering from Obesity.......");
		}
	}
}
