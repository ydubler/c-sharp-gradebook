using System;
using System.Collections.Generic;

namespace GradeBook
{
    // Super class
    // This is an object with a string requirement as a name
    class NamedObject
    {
        public NamedObject(string name)
        {
            Name = name;
        }

        // Class has a public string property with getters and setters
        public string Name
        {
            get;
            set;
        }
    }

    // Abstract classes can't be instantiated but they can be subclassed
    abstract class BookBase : NamedObject
    {
        protected BookBase(string name) : base(name)
        {
        }

        public abstract void AddGrade(double grade);
    }

    class Book : BookBase
    {
        // Constructor
        // Have to pass name string into base constructor using "base(name)"
        public Book(string name) : base(name)
        {
            grades = new List<double>();
            averageGrade = 0.0;
            Name = name;
        }

        // Class properties
        // private is only accessible inside the class
        private List<double> grades; // Defined in constructor
        private double averageGrade; // Defined in constructor 
        private List<double> priorGrades = new List<double> { 77.5, 45.6, 89.5, 92.0, 99.0, 84.0 }; // Defined here
        public static void Describe()
        {
            Console.WriteLine("The Book class is responsible for storing and averaging grades.");
        }

        public override void AddGrade(double grade)
        {
            grades.Add(grade);
            Console.WriteLine("Added grade " + grade + " to GradeBook");
        }

        // public void AddGrade(double grade)
        // {
        //     grades.Add(grade);
        //     Console.WriteLine("Added grade " + grade + " to GradeBook");
        // }

        public void AverageGrades()
        {
            double sum = 0;
            foreach (double val in grades)
            {
                sum += val;
            }
            double avg = sum / grades.Count;
            averageGrade = avg;
            Console.WriteLine("Average grade is " + avg);
        }


    }
}
