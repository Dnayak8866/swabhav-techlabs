using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Student, Student> students = new Dictionary<Student, Student>();
            Student s1 = new Student("A", 11, 9);
            Student s2 = new Student("C", 10, 6);
            Student s3 = new Student("B", 11, 9);
            Student s4 = new Student("A", 11, 9);
            PutInDictionary(s1, students);
            PutInDictionary(s2,students);
            PutInDictionary(s3, students);
            PutInDictionary(s4, students);
            DisplayStudents(students);
        }

       

        private static void PutInDictionary(Student student, Dictionary<Student, Student> students)
        {
            Boolean isToADd = false;
            if (students.Count == 0)
            {
                students.Add(student,student);

            }else
            {
                foreach (KeyValuePair<Student,Student> entry in students)
                {
                    if (entry.Value.Standard == student.Standard)
                    {
                        if (student.RollNo == entry.Value.RollNo)
                        {
                            
                            Console.WriteLine("Student {0} already there with same class and same rollno.....",entry.Value.Name);
                            isToADd = false;
                            break;
                        }
                    }else
                    {
                        isToADd = true;
                    }
                }

                if (isToADd)
                {
                    students.Add(student,student);
                }
            }
        }


        private static void DisplayStudents(Dictionary<Student, Student> students)
        {
            foreach (KeyValuePair<Student,Student> student in students)
            {
                Console.WriteLine("Name :" + student.Value.Name
                    + "\n Roll No :" + student.Value.RollNo
                    + "\nStandard :" + student.Value.Standard);
            }
        }
    }
}
