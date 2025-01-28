using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
     public class Student
    {
        public string Name { get; set; }
        private List<double> grades;

        public Student(string name)
        {
            Name = name;
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
            Console.WriteLine($"Оценка {grade} добавлена для студента {Name}.");
        }

         public double GetAverageGrade()
        {
            if (grades.Count == 0)
            {
                return 0; 
            }
            double total = 0;
            foreach (var grade in grades)
            {
                total += grade;
            }
            return total / grades.Count;
        }
    }

     public class Classroom
    {
        private List<Student> students;

        public Classroom()
        {
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine($"Студент {student.Name} добавлен в класс.");
        }

        public Student GetTopStudent()
        {
            Student topStudent = null;
            double highestAverage = 0;

            foreach (var student in students)
            {
                double average = student.GetAverageGrade();
                if (average > highestAverage)
                {
                    highestAverage = average;
                    topStudent = student;
                }
            }

            return topStudent;
        }
    }

     public class Program
    {
        public static void Main()
        {
             Classroom classroom = new Classroom();

            Student student1 = new Student("Полина шерышова");
            Student student2 = new Student("Мария шерышова");
            Student student3 = new Student("Алина шерышова");
            

            
            classroom.AddStudent(student1);
            classroom.AddStudent(student2);
            classroom.AddStudent(student3);

            
            student1.AddGrade(4.5);
            student1.AddGrade(5.0);
            student2.AddGrade(5.0);
            student2.AddGrade(4.0);
            

            Student topStudent = classroom.GetTopStudent();
            if (topStudent != null)
            {
                Console.WriteLine($"Студент с самым высоким средним баллом: {topStudent.Name}, Средний балл: {topStudent.GetAverageGrade()}");
            }
        }
    }
}