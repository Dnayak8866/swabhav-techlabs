package com.techlabs.calculator;

import static org.junit.Assert.*;

import java.io.ObjectOutputStream.PutField;

import org.junit.Test;

public class CubeOddNumber {

	@SuppressWarnings("deprecation")
	@Test
	public void test() {
		Calculator c = new Calculator();
		double output = c.cubeOddNumber(4);
		assertEquals(27, output, 64);
		
		
	}

}
