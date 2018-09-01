package com.techlabs.simplefactory.pattern;

public class WheelFactory {
	public static Wheel makeWheel (float diameter, String style) {
        return new CarWheel(style, diameter);
    }
}
