package com.techlabs.facade.pattern.test;

import com.techlabs.facade.pattern.Admin;

public class TestFacade {
	public static void main(String[] args) {
		Admin admin = new Admin();
		admin.computerDepartment();
		admin.mechDepartment();
	}
}
