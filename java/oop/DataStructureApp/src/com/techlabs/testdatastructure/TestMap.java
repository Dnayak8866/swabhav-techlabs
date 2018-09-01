package com.techlabs.testdatastructure;

import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.LinkedHashSet;
import java.util.Map;
import java.util.TreeMap;

public class TestMap {
	public static void main(String[] args) {

		System.out.println("........Hash Map........");
		implementHashMap();
		System.out.println("........Tree Map........");
		implementTreeMap();
		System.out.println("........Linked Hash Map........");
		implementLinkedHashMap();
	}

	private static void implementHashMap() {
		HashMap<String, Integer> map = new HashMap<String, Integer>();
		map.put("Dharmesh", 394221);
		map.put("Chandan", 213232);
		map.put("Abhishek", 45664);

		displayHashMap(map);
		System.out.println("After cloning.........");
		HashMap<String, Integer> map1 = (HashMap<String, Integer>) map.clone();
		displayHashMap(map1);
		System.out.println(" Value of Dharmesh :" + map1.get("Dharmesh"));
	}

	private static void displayHashMap(HashMap<String, Integer> map) {
		if (map.isEmpty()) {
			System.out.println("Map is empty........");
		} else {
			System.out.println(map);
		}

	}

	private static void implementTreeMap() {
		TreeMap<Integer, String> treemap = new TreeMap<Integer, String>();
		System.out.println("Element addded...........");
		treemap.put(1, "A");
		treemap.put(4, "B");
		treemap.put(3, "C");
		
		displayTreeMap(treemap);
		System.out.println("Element with key 1 removed :");
		treemap.remove(1);
		displayTreeMap(treemap);
		
		System.out.println("Element updated......");
		treemap.put(6, "E");
		displayTreeMap(treemap);

	}

	private static void displayTreeMap(TreeMap<Integer, String> treemap) {
		for (Map.Entry<Integer, String> m : treemap.entrySet()) {
			System.out.println("Key :" + m.getKey() + " Value :" + m.getValue()
					+ "\n");
		}

	}

	private static void implementLinkedHashMap() {
		LinkedHashMap<String, Integer> linkedHashMap = new LinkedHashMap<String, Integer>();
		linkedHashMap.put("Dharmesh", 1321);
		linkedHashMap.put("Chandan", 13121);
		linkedHashMap.put("Abhishek", 5464);
		
		displayLinkedHashMap(linkedHashMap);
		
		System.out.println("Element Sunil is added.......");
		linkedHashMap.put("Sunil", 212321);
		displayLinkedHashMap(linkedHashMap);
		
		System.out.println("Element Sunil is removed  ");
		linkedHashMap.remove("Sunil");
		displayLinkedHashMap(linkedHashMap);

	}

	private static void displayLinkedHashMap(LinkedHashMap<String, Integer> linkedHashMap) {
		for (Map.Entry<String, Integer> m : linkedHashMap.entrySet()) {
			System.out.println("Key :" + m.getKey() + "Value :" + m.getValue()
					+ "\n");
		}
		
	}

}
