package com.techlabs.datastructure.sorted.account;

import java.util.Comparator;

public class AccountNoComparable implements Comparator<Account> {
	@Override
	public int compare(Account  ac1,Account ac2) {
		if(ac1.getAcntNo()>ac2.getAcntNo()){
			return 1;
		}else if(ac1.getAcntNo()==ac2.getAcntNo()){
			return  0;
		}else{
			return -1;
		}
		
	
	
}
	
	
}
