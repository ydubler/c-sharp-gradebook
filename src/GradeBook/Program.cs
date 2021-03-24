using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book.Describe(); // public static method only accessible to class
            Book GradeBook = new Book("Spring 97 Algebra I (Ms Greenlaw)");
            GradeBook.Name = "Spring '97 Algebra I (Mrs. Greenlaw)";
            GradeBook.AddGrade(69);
            GradeBook.AddGrade(75);
            GradeBook.AddGrade(92);
            GradeBook.AddGrade(77);
            GradeBook.AddGrade(46);
            GradeBook.AddGrade(87);
            GradeBook.AddGrade(94);
            GradeBook.AverageGrades();
        }
    }
}
