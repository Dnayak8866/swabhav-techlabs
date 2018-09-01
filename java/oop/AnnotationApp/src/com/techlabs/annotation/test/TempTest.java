package com.techlabs.annotation.test;

import java.lang.reflect.Method;
import java.lang.annotation.Retention;
import java.lang.annotation.RetentionPolicy;

@Retention(RetentionPolicy.RUNTIME)
@interface needsToChange {
	boolean value();
}

public class TempTest {

	public void testMethod1() {
		System.out.println("hello");
	}

	@needsToChange(value = true)
	public void testMethod2() {
		System.out.println("hello");
	}

	@needsToChange(value = false)
	public void testMethod3() {
		System.out.println("hello");
	}

	public static void main(String arg[]) {
		Class<? extends TempTest> cls = TempTest.class;
		Method[] methods = cls.getMethods();

		for (Method method : methods) {
			if (method.isAnnotationPresent(needsToChange.class)) {
				needsToChange myAnnotation = method
						.getAnnotation(needsToChange.class);
				System.out.println("Is the method " + method.getName()
						+ " needs to change :" + myAnnotation.value());
			}

		}

	}
}
