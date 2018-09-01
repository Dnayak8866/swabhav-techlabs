package com.techlabs.srp.solution;

public class InvoiceRefractor {
	private int invoiceNo;
	private String description;
	private double cost;
	private float discountRate;
	private float gstRate;
	
	
	
	public InvoiceRefractor(int invoiceNo,String description,double cost,float discounRate,float gstRate){
		this.invoiceNo=invoiceNo;
		this.description=description;
		this.cost=cost;
		this.discountRate=discounRate;
		this.gstRate=gstRate;
		
	}
	
	private double calculateDiscount(){
		return (0.01)*this.discountRate*cost;
	}
	
	private double calculateTax(){
		return (0.01)*this.gstRate*cost;
	}
	
	public double calculateTotalCost(){
		return ((this.cost+calculateTax())-calculateDiscount());
	}
	
	public int getInvoiceNo(){
		return this.invoiceNo;
	}
	
	public String getDecription(){
		return this.description;
	}
	
	public double getCost(){
		return this.cost;
	}
	public float getDiscountRate(){
		return this.discountRate;
	}
	
	public float getGstTaxRate(){
		return this.gstRate;
	}
	
	
	public String toString(){
		return "\nInvoice No :"+this.invoiceNo
				+"\nInvoice description :"+this.description
				+"\nCost :"+this.cost
				+"\nDiscount Rate:"+this.discountRate+"%"
				+"\nGst Rate :"+this.gstRate+"%"
				+"\nTotal Cost :"+calculateTotalCost();
	}

}
