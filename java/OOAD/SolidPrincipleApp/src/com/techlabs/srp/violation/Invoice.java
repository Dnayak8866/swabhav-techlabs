package com.techlabs.srp.violation;

public class Invoice {
	private int invoiceNo;
	private String description;
	private double cost;
	private float dicountRate;
	private float gstRate;
	private double taxAmount;
	private double discountAmount;
	
	
	public Invoice(int invoiceNo,String description,double cost,float discounRate,float gstRate){
		this.invoiceNo=invoiceNo;
		this.description=description;
		this.cost=cost;
		this.dicountRate=discounRate;
		this.gstRate=gstRate;
		
	}
	
	public double calculateDiscount(){
		
		return (0.1)*this.dicountRate*cost;
	}
	
	public double calculateTax(){
		this.taxAmount= (0.1)*this.gstRate*cost;
		return this.taxAmount;
	}
	
	public double calculateTotalCost(){
		return ((this.cost+this.taxAmount)-this.discountAmount);
	}
	
	public void  printInoice(){
		System.out.println("\nInvoice No :"+this.invoiceNo
				+"\nInvoice description :"+this.description
				+"\nCost :"+this.cost
				+"\nDiscount :"+this.discountAmount
				+"\nTax Amount :"+this.taxAmount
				);
	}
}
