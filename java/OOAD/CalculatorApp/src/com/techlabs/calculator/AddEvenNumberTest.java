package com.techlabs.calculator;

import static org.junit.Assert.*;

import org.junit.Test;

public class AddEvenNumberTest {

	@Test
	public void test() {
		Calculator c = new Calculator();
		int output = c.addEvenNumber(2, 4);
		assertEquals(6, output);
	}

}
