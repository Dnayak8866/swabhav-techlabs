package com.techlabs.employe.analyzer.test;

import static org.junit.Assert.*;

import java.util.ArrayList;

import org.junit.Test;

import com.techlabs.employe.analyzer.LoadFromDisk;
import com.techlabs.employe.analyzer.LoadFromUrl;

public class LoadFileTestCase {

	@Test
	public void LoadFile() {
		ArrayList<String> data;
		LoadFromUrl load = new LoadFromUrl();
		data =load.loadData();

			System.out.println(data);
		
	}

}
