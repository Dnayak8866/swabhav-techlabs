package com.techlabs.prolinklist.test;

import com.techlabs.prolinklist.Node;
import com.techlabs.prolinklist.ProLinkList;

public class ProLinkListTest {
	public static void main(String[] args) {
		ProLinkList<String> proLinkList = new ProLinkList<String>();
		proLinkList.add(new Node<String>("Dharmesh"));
	//	proLinkList.add(new Node<String>("chandan"));
		//proLinkList.add(new Node<String>("Abhishek"));
		System.out.println(proLinkList.getNode(0));
		System.out.println(proLinkList.remove(0));
		System.out.println(proLinkList.getNode(0));
		
		System.out.println(proLinkList.getSize());
		
		
		
		
	}
}
