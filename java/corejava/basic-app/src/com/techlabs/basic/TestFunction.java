package com.techlabs.basic;

public class TestFunction {
	public static void main(String[] args){
		//int mark=100;
		//change(mark);
		//System.out.println(mark);
		int marks[] = {10,20,30};
		changemarks(marks);
		for(int j=0;j<marks.length;j++){
			System.out.println(marks[j]);
		}
		
		
	}
	private static void change(int mark){
		mark=0;
	}
	private static void changemarks(int[] pmarks){
		for(int i=0;i<pmarks.length;i++){
			pmarks[i]=0;
		}
	}

}
