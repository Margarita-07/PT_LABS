using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics
{
    public class Student
    {
        public string name;
        public string group;
       

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Group
        {
            get { return group; }
            set { group = value; }
        }

        private double gpa;
        public double GPA  //s1.GPA = 4;
        {
            get { return gpa; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException(nameof(GPA), "GPA must be between 0 and 10.");
                }
                gpa = value;
            }
        }
          
        public Student(string name, string group, double gpa)
        {
            Name = name;
            Group = group;
            GPA = gpa; // Используется свойство с валидацией
        }

        public bool IsExcellent()
        {
            return GPA >= 8;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Student: {Name}, Group: {Group}, GPA: {GPA:F2}, Excellent: {IsExcellent()}");
        }
    }

}
