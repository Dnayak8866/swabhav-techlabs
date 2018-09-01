package com.techlabs.basic;

import java.util.HashMap;

public class TestString {
	 public static void main(String arg[]){
		 /*
		String url="https://www.xyzcom?user=\"dharmesh\"";
		String domainPart;
		String userPart;
		String twoparts[]={};
		String secondpart= new String();
		int j=0;
		String s1[] = url.split("[.|\"]");
		for(int i=0;i<s1.length;i++){
			System.out.println(s1[i]);
		}
		HashMap<String, String> map = new HashMap<String, String>();
		map.put(s1[1], s1[3]);
		System.out.println("Domain is.."+map.keySet()+"\nUser: "+map.values());
		
		
		*/
		 String url="https://www.xyzvzvz.com?user=\"dharmesh\"";
		 String splitedString[] = url.split("[:|?|\"]");
		 for(int i=0;i<splitedString.length;i++){
				System.out.println(splitedString[i]);
			}
		 for(int i=1;i<splitedString.length;i++){
				switch(i){
				case 1:
					int l1 = splitedString[i].length();
					String domain = splitedString[i].substring(2,l1);
					System.out.println("Doman is: "+domain);
					break;
				case 3:
					System.out.println("User is:"+splitedString[i]);
				}
			}
		 
			

		
	}
	
}
