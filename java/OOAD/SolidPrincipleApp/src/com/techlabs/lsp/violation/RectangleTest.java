package com.techlabs.lsp.violation;

import static org.junit.Assert.*;

import org.junit.Test;

public class RectangleTest {

	
	public boolean shouldnotChangeWidthIfHeightChange (Rectangle r) {
		int beforeChangeWidth = r.getWidth();
		r.setHeight(r.getHeight()+50);
		int afterChangeWidth = r.getWidth();
		return (beforeChangeWidth==afterChangeWidth);
		
	}
	
	@Test
	public void testRectangle(){
		Rectangle r = new Rectangle(70, 20);
		assertEquals(true, shouldnotChangeWidthIfHeightChange(r));
	}
	
	@Test
	public void testSquare(){
		Square s = new Square(70);
		assertEquals(true, shouldnotChangeWidthIfHeightChange(s));
	}

}
