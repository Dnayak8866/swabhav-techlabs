package com.techlabs.student.test;


import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import java.util.Map.Entry;

import com.techlabs.student.Student;

public class StudentTest {
	public static void main(String[] args) {
		Map<Student, Student> map = new HashMap<Student, Student>();
		Student s1 = new Student("A", 11, 9);
		Student s2 = new Student("C", 10, 6);
		Student s3 = new Student("B", 11, 9);
		Student s4 = new Student("A", 11, 9);

		putInMap(s1, map);
		putInMap(s2, map);
		putInMap(s3, map);
		putInMap(s4, map);
		displayStudents(map);

	}



	private static void putInMap(Student student, Map<Student, Student> map) {
		boolean isToADd = false;

		if (map.isEmpty()) {
			map.put(student, student);
		} else {
			Iterator<Entry<Student, Student>> iterator = map.entrySet().iterator();
			while (iterator.hasNext()) {
				Map.Entry pair = (Map.Entry) iterator.next();
				Student studentInMap = (Student) pair.getValue();
				if (student.getStandard() == studentInMap.getStandard()) {
					if (student.getRollNo() == studentInMap.getRollNo()) {
						System.out
								.println("Students from same class with same roll No...");
						isToADd = false;
						break;
					}

				}
				else{
					isToADd=true;
				}
			
			}
			if (isToADd) {
				map.put(student, student);
			}

		}
		// System.out.println(map);

		
	}
	private static void displayStudents(Map<Student, Student> map) {
		for (Map.Entry<Student, Student> m : map.entrySet()) {
			Student singleStudent = (Student) m.getValue();
			System.out.println("Name :" + singleStudent.getName()
					+ "\n Roll No :" + singleStudent.getRollNo()
					+ "\nStandard :" + singleStudent.getStandard());
		}
		
	}
}
