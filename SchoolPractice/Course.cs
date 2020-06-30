using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        public string CourseName { get; set; }
        public string Teacher { get; set; }
        public List<Student> Roster { get; set; }

        public Course()
        {
        }
    }
}
