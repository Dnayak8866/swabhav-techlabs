package com.techlabs.employe.analyzer.test;

import static org.junit.Assert.*;

import org.junit.Test;

import com.techlabs.employe.analyzer.LoadFromDisk;
import com.techlabs.employe.analyzer.Parser;

public class ParserTestCase {

	@Test
	public void parser() {
		Parser parser = new Parser(new LoadFromDisk().loadData());
		parser.parseData();
	}

}
