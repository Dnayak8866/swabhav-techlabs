package com.techlabs.rectangle;
import java.lang.reflect.Constructor;
import java.lang.reflect.Method;
import java.lang.reflect.Field;

public class TestReflectionObjectClass {
	public static void main(String arg[]) throws NoSuchMethodException{
		//Using Reflection API
				Class<Object> cls = Object.class;
				System.out.println("Class name of object-rectangleone : "+cls.getName());
				System.out.println("----------------------------------------------------------");
				
				Constructor<?>[] constructors = cls.getConstructors();
				for(Constructor<?> constructor:constructors){
					System.out.println("Constructor of Rectangle Class is : "+constructor.getName());
				}
				System.out.println("----------------------------------------------------------");
				
				
				Method[] methods = cls.getMethods();
				for(Method method:methods){
					System.out.println("Method is......"+method.getName());
				}
				System.out.println("----------------------------------------------------------");
				
				Field[] fields = cls.getFields();
				for(Field field:fields){
					System.out.println("Field is..."+field.getName());
				}
		
	}
}
