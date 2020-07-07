using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.

            Student me = new Student();
            me.Name = "vaishu";
            me.NumberOfCredits = 1;
            me.Gpa = 4.0;

            Student you = new Student();
            you.Name = "arav";
            you.NumberOfCredits = 0;
            you.Gpa = 2.0;

            Console.WriteLine(me.Name + " has the GPA of " + me.Gpa + " with no of credits = " + me.NumberOfCredits);
            Console.WriteLine(you.Name + " has the GPA of " + you.Gpa + " with no of credits = " + you.NumberOfCredits);


            Course stlcc = new Course();
            stlcc.CourseName = "Code Camp";
            stlcc.Teacher = "Ben";

            List<Student> studentList = new List<Student>();//List of Student Objects
            studentList.Add(me);
            studentList.Add(you);

            stlcc.Roster = studentList;//Roster contains "list" of "Student Objects"

            Console.WriteLine("The teacher for the course " + stlcc.CourseName + "is " + stlcc.Teacher);
            Console.WriteLine(stlcc.Roster[0].Name);
           


            Teachers teacher = new Teachers();
            teacher.FirstName = "Ben";
            teacher.LastName = "Clark";
            teacher.Subject = "C#";
            teacher.YearsOfTeaching = 3;




























            //Student Vaishu = new Student();
            //Student You = new Student();
            //List<Student> StudentList = new List<Student>();
            //StudentList.Add(Vaishu);
            //StudentList.Add(You);


            //Course CodeCamp = new Course();

            //CodeCamp.CourseName = "code camp";
            //CodeCamp.Teacher = "ko ko";
            //CodeCamp.Roster = StudentList;
            ////Console.WriteLine(Vaishu.Gpa);
            //Vaishu.NumberOfCredits = 1;
            //Vaishu.Gpa = 4.0;
            //Vaishu.Name = "vaishu";
            //Console.WriteLine(Vaishu.Name + "'s No of credits is" + Vaishu.NumberOfCredits);
            //Console.WriteLine(CodeCamp.Roster[0].Name);


        }
    }
}
