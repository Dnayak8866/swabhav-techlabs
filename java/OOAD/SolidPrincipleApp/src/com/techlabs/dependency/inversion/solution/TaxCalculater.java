package com.techlabs.dependency.inversion.solution;


public class TaxCalculater {
	private Logger logger;
	private int salary;
	private int rate;

	public TaxCalculater(Logger logger) {
		this.logger=logger;
	}

	public int calculateTax(int salary,int rate){
		int result=0;
		try{
			result = salary/rate;
			if(result<0){
				throw new Exception("Negative result....");

			}
			System.out.println("Result :"+result);
		}catch(Exception e){
			logger.Log(e);
			
		}
	
		return result; 
		
		
	}
}
