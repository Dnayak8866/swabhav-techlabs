package com.techlabs.testdatastructure;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.Iterator;
import java.util.LinkedHashSet;
import java.util.TreeSet;

public class TestSet {
	
	public static void main(String[] args) {
		System.out.println("............Hash Set.......");
		String[] cities = {"Surat","Ahmedabad","Mumbai","Hyderabad"};
		implementHashSet( cities);
		System.out.println("........LinkedHashSet......");
		implementLinkedHashSet(cities);
		System.out.println("........TreeSet......");
		implementTreeSet(cities);
	}

	private static void implementHashSet(String[] cities) {
		HashSet<String> hashSetCities = new HashSet<String>();
		for(String city:cities){
			hashSetCities.add(city);
		}
		//cannot add duplicate values (Surat)
		hashSetCities.add("Surat");
		hashSetCities.add("Vadodara");
	
		System.out.println("Is Surat city in the list "+hashSetCities.contains("Surat"));
		System.out.println("Citites : "+hashSetCities);
		System.out.println("Removing city Hyderabad from list.....");
		hashSetCities.remove("Hyderabad");
		System.out.println("Cities : "+hashSetCities);
	}
	
	private static void implementLinkedHashSet(String[] cities) {
		LinkedHashSet<String> linkedHashSetCities = new LinkedHashSet<String>();
		LinkedHashSet<String> newlinkedHashSetCities = new LinkedHashSet<String>();
		for(String city:cities){
			linkedHashSetCities.add(city);
		}
		//cannot add duplicate value 
		linkedHashSetCities.add("Surat");
		System.out.println("Cities :"+linkedHashSetCities);
		System.out.println("Size of linkedhashset is :"+linkedHashSetCities.size());
		
		System.out.println("Removing city hyderabad from list......");
		linkedHashSetCities.remove("Hyderabad");
		System.out.println("Cities of linkedhashset :"+linkedHashSetCities);
		
		System.out.println("........Add new list of  Cities.......");
		newlinkedHashSetCities.add("Anand");
		newlinkedHashSetCities.add("Bhubaneshwar");
		newlinkedHashSetCities.add("Surat");
		System.out.println("Cities  of newlinkedhashset:"+newlinkedHashSetCities);
		
		System.out.println("Removing all matching elements in list1 from list2");
		//removes newlinkedHashSetCities elements from linkedhashSetCities
	    linkedHashSetCities.removeAll(newlinkedHashSetCities);
	    System.out.println("Cities of linkedhashset :"+linkedHashSetCities);
	    
	    linkedHashSetCities.add("Surat");
	  
	    System.out.println("Keeping all matching elements in list1 from list2 remove remaining all in list1");
	    //keeps newlinkedHashSetCities elements from linkedhashSetCities and remove remaining elements
	    linkedHashSetCities.retainAll(newlinkedHashSetCities);
	    System.out.println("Cities of linkedhashset:"+linkedHashSetCities);	
	}
	
	private static void implementTreeSet(String[] cities) {
		TreeSet<String> citylist = new TreeSet<String>(); 
		for(String city:cities){
			citylist.add(city);
		}
		System.out.println("Cities are  :"+citylist);
		System.out.println("Ceiling value for Mum :"+citylist.ceiling("Mum"));
		System.out.println("Cities are  :"+citylist);
	
		
		citylist.add("Delhi");
		System.out.println("First Element :"+citylist.first());
		
		
	}

}
