package com.techlabs.dependency.inversion;

public class TaxCalculator {
	private LogType logType;
	
	public TaxCalculator(LogType logType){
		this.logType= logType;
	}
	
	public int calculateTax(int salary,int rate){
		int result=0;
		try{
			result=salary/rate;
			System.out.println(result);
		}catch(Exception e){
			if(this.logType==LogType.TXT){
				TestLogger textLogger = new TestLogger();
				textLogger.log("Unwanted result...");
			}else if(this.logType==LogType.DB){
				DbLogger dbLogger = new DbLogger();
				dbLogger.log("Unwanted result....");
			}else{
				EmailLogger emailLogger = new EmailLogger();
				emailLogger.log("Unwanted result....");
			}
		}
		return result;
		
	}
	
	
}
