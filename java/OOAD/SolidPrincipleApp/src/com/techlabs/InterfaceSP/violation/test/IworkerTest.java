package com.techlabs.InterfaceSP.violation.test;

import com.techlabs.InterfaceSP.violation.Iworker;
import com.techlabs.InterfaceSP.violation.Manager;
import com.techlabs.InterfaceSP.violation.Robot;

public class IworkerTest {
	public static void main(String[] args) {
		atTheWork(new Manager());
		atTheWork(new Robot());
		atTheCafe(new Manager());
		atTheCafe(new Robot());
	}

	private static void atTheCafe(Iworker worker) {
		System.out.println("At the cafe");
		worker.startEat();
		worker.stopEat();
	}

	private static void atTheWork(Iworker worker) {
		System.out.println("At the work");
		worker.startwork();
		worker.stopWork();	
	}
}
