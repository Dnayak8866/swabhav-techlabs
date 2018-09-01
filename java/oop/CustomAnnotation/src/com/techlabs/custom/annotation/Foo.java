package com.techlabs.custom.annotation;

import java.lang.annotation.Retention;
import java.lang.annotation.RetentionPolicy;
import java.lang.reflect.Method;


@Retention(RetentionPolicy.RUNTIME)
@interface SwabhavTestCase {
	boolean value();
}

public class Foo {
	@SwabhavTestCase(value = true)
	public void testMethod1() {
		System.out.println("hello");
	}


	public void testMethod2() {
		System.out.println("hello");
	}
	
	@SwabhavTestCase(value = true)
	public void testMethod3() {
		System.out.println("hello");
	}
	
	@SwabhavTestCase(value = false)
	public void testMethod4() {
		System.out.println("hello");
	}
	public static void main(String arg[]){
		Class<Foo> cls = Foo.class;
		Method[] methods = cls.getMethods();

		for (Method method : methods) {
			if (method.isAnnotationPresent(SwabhavTestCase.class)) {
				SwabhavTestCase myAnnotation = method.getAnnotation(SwabhavTestCase.class);
				if(myAnnotation.value()==true){
					System.out.println("Test case of Method-"+method+" is Pass");
				}else{
					System.out.println("Test case of Method-"+method+" is Fail");
				}
				
			}

		}
	}

}
