using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public double CGPA { get; set; }


        public Student(int rollno, string name, double cgpa)
        {

            if (rollno <= 0)
            {
                Console.WriteLine("Invalid RollNo! RollNo should be positive.");
                RollNo = 0;
            }
            else
            {
                RollNo = rollno;
            }


            if (name.Length >= 5)
            {
                Name = name;
            }
            else
            {
                Console.WriteLine("Invalid Name! Name should have at least 5 characters.");
                Name = string.Empty; 
            }


            if (cgpa >= 1 && cgpa <= 10)
            {
                CGPA = cgpa;
            }
            else
            {
                Console.WriteLine("Invalid CGPA! CGPA should be between 1 and 10.");
                CGPA = 0;
            }
        }


        public double GetPercentage()
        {
            if (CGPA < 1 || CGPA > 10)
            {
                Console.WriteLine("Invalid CGPA, cannot calculate percentage.");
                return 0;
            }

            return CGPA * 9.5 + 11;
        }


        public void DisplayStudentInfo()
        {
           
                Console.WriteLine($"RollNo: {RollNo}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"CGPA: {CGPA}");
                Console.WriteLine($"Percentage: {GetPercentage():F2}");
            




        }
    }
}