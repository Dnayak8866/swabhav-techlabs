package com.techlabs.employee;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

public class ExportData {
	
	

	public static  void exportToHtml(Employee e) throws IOException{
		File htmlFile= new File("N:\\Localrepository\\Employee"+e.getId()+".html");
		String html ="<html>\n<head>\n<title>\n</title>\n</head>\n<body>\n<pre>\nName :"+e.getName()+"\nID :"+e.getId()+"\nAllowances :"
				+e.getAllowance()+"\nTotal Salary :"+e.getTotalSalary()+"</pre>\n</body>\n</html>";
		BufferedWriter writer = new BufferedWriter(new FileWriter(htmlFile));
		writer.append(html);
		writer.close();
	}

}
