using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.

            Student Vaishu = new Student();
            Student You = new Student();
            List<Student> StudentList = new List<Student>();
            StudentList.Add(Vaishu);
            StudentList.Add(You);


            Course CodeCamp = new Course();

            CodeCamp.CourseName = "code camp";
            CodeCamp.Teacher = "ko ko";
            CodeCamp.Roster = StudentList;
            //Console.WriteLine(Vaishu.Gpa);
            Vaishu.NumberOfCredits = 1;
            Vaishu.Gpa = 4.0;
            Vaishu.Name = "vaishu";
            Console.WriteLine(Vaishu.Name + "'s No of credits is" + Vaishu.NumberOfCredits);
            Console.WriteLine(CodeCamp.Roster[0].Name);
            

        }
    }
}
