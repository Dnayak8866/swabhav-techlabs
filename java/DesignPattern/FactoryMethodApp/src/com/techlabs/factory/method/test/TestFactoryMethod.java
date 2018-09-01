package com.techlabs.factory.method.test;


import java.io.FileReader;
import java.io.IOException;
import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;
import java.util.Properties;







import com.techlabs.factory.method.AudiFactory;
import com.techlabs.factory.method.BmwFactory;
import com.techlabs.factory.method.IAutoFactory;
import com.techlabs.factory.method.IAutomobile;

public class TestFactoryMethod {
	public static void main(String[] args) throws IOException, ClassNotFoundException, NoSuchMethodException, SecurityException, IllegalAccessException, IllegalArgumentException, InvocationTargetException {
		IAutoFactory factory1 = new BmwFactory();
		IAutomobile bmw = factory1.make();
		bmw.start();
		bmw.stop();

		IAutoFactory factory2 = AudiFactory.getInstance();
		IAutomobile audi = factory2.make();
		audi.start();
		audi.stop();
		
		//System.out.println(Class.forName(createFactoryInstance()).getSimpleName());
		Class<?> c =  Class.forName(createFactoryInstance());
		Method m = c.getDeclaredMethod("getInstance");
		
		IAutoFactory factory3 = (IAutoFactory) m.invoke(c);
		IAutomobile carBrand = factory3.make();
		carBrand.start();
		carBrand.stop();
		
	
		

	}

	private static String createFactoryInstance() throws IOException {
		Properties properties = new Properties();
		String propertyfile ="resources/config.properties" ;
		FileReader reader = new FileReader(propertyfile);
		properties.load(reader);
		System.out.println(properties.getProperty("app.currentFactory"));
		return properties.getProperty("app.currentFactory");
		
	}
}
