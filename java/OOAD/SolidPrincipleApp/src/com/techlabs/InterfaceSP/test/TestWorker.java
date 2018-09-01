package com.techlabs.InterfaceSP.test;

import com.techlabs.InterfaceSP.solution.Eat;
import com.techlabs.InterfaceSP.solution.Manager;
import com.techlabs.InterfaceSP.solution.Work;
import com.techlabs.InterfaceSP.solution.Robot;

public class TestWorker {
	public static void main(String[] args) {
		atTheWork(new Manager());
		atTheWork(new Robot());
		atTheCafe(new Manager());
		
		

	}

	private static void atTheWork(Work work) {
		System.out.println("At the Work");
		work.startWork();
		work.stopWork();
		
	}

	private static void atTheCafe(Eat eat) {
		System.out.println("At the cafe");
		eat.startEat();
		eat.stopEat();
	}

}
